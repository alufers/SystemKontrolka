using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SystemKontrolka.Models;
using SystemKontrolka.Services;

namespace SystemKontrolka
{
    /// <summary>
    /// Interaction logic for MainSystemWindow.xaml
    /// </summary>
    public partial class MainSystemWindow : Window
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly AddUserWindow _addUserWindow;
        private readonly KontrolkaDbContext _kontrolkaDbContext;
        private readonly AddReportWindow _addReportWindow;
        private ILoginService _loginService;
        private User _user;
        public MainSystemWindow(IServiceProvider serviceProvider, AddUserWindow addUserWindow,
            KontrolkaDbContext kontrolkaDbContext, ILoginService loginService, AddReportWindow addReportWindow)
        {
            _serviceProvider = serviceProvider;
            _addUserWindow = addUserWindow;
            _kontrolkaDbContext = kontrolkaDbContext;
            _loginService = loginService;
            _addReportWindow = addReportWindow;
            InitializeComponent();
        }

        /// <summary>
        /// Sets up the window for the given user and shows it.
        /// </summary>
        /// <param name="user"></param>
        public void LoginAndShow(User user)
        {
            _user = user;

            LoggedInLabel.Content =
                $"Zalogowany jako: {_user.Username}";
            Show();
        }


        /// <summary>
        /// Handles a click on the logout button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            SaveLogoutAndExit();
        }

        private async Task SaveLogoutAndExit()
        {
            await _loginService.CreateLoginHistoryEntry(_user, "Wylogowano!");
            Hide();
            Application.Current.Shutdown();
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            _addUserWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            LoadUsers();
            LoadLoginHistory();
            LoadPartTypes();
            LoadReports();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LoadUsers();
            LoadLoginHistory();
            LoadPartTypes();
            LoadReports();
        }

        /// <summary>
        /// Loads the users list from the database
        /// </summary>
        /// <returns></returns>
        public async Task LoadUsers()
        {
            var users = await _kontrolkaDbContext.Users.ToListAsync();
            UsersDataGrid.ItemsSource = users;
        }

        public async Task LoadLoginHistory()
        {
            var loginHistory = await _kontrolkaDbContext.loginHistoryEntries.Include(l => l.User).ToListAsync();
            LogsDataGrid.ItemsSource = loginHistory;
        }

        /// <summary>
        /// Loads part types from the database to the Datagrid
        /// </summary>
        /// <returns></returns>
        public async Task LoadPartTypes()
        {
            var partTypes = await _kontrolkaDbContext.Parts.ToListAsync();
            PartTypesDataGrid.ItemsSource = partTypes;
        }
        
        /// <summary>
        /// Loads reports from the database to the datagrid
        /// </summary>
        /// <returns></returns>
        public async Task LoadReports()
        {
            var reports = await _kontrolkaDbContext.Reports.Include(l => l.Part).Include(l => l.User).ToListAsync();
            ReportsDataGrid.ItemsSource = reports;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private async void PartTypesDataGrid_EditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {

            if (e.EditAction == DataGridEditAction.Commit)
            {
                var _part = e.Row.Item as Part;
                if (_part.Id == 0)
                {
                    _kontrolkaDbContext.Parts.Add(_part);
                }
                else
                {
                    _kontrolkaDbContext.Parts.Update(_part);
                }
                await _kontrolkaDbContext.SaveChangesAsync();
                await LoadPartTypes();
            }
        }

        /// <summary>
        /// Shows the add report window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddReportButton_Click(object sender, RoutedEventArgs e)
        {
            _addReportWindow.ShowForUser(_user);
        }
    }
}
