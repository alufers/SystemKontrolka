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
        public MainSystemWindow(IServiceProvider serviceProvider, AddUserWindow addUserWindow, KontrolkaDbContext kontrolkaDbContext)
        {
            _serviceProvider = serviceProvider;
            _addUserWindow = addUserWindow;
            _kontrolkaDbContext = kontrolkaDbContext;
            InitializeComponent();
        }


        /// <summary>
        /// Handles a click on the logout button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            _serviceProvider.GetService<LoginWindow>().Show();
            Hide();
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            _addUserWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            LoadUsers();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LoadUsers();
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
    }
}
