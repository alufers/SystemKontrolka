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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SystemKontrolka.Services;


namespace SystemKontrolka
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        private readonly ILoginService _loginService;
        private readonly MainSystemWindow _mainSystemWindow;



        public LoginWindow(ILoginService loginService, MainSystemWindow mainSystemWindow)
        {
            _loginService = loginService;
            _mainSystemWindow = mainSystemWindow;
            InitializeComponent();
        }

        /// <summary>
        /// Handles keypresses in text fields, checks for enter and continues login whenenter was pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                DoLogin();
            }
        }

        /// <summary>
        /// Click handler for the login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            DoLogin();
        }

        /// <summary>
        /// Performs the actual login action
        /// </summary>
        /// <returns></returns>
        private async Task DoLogin()
        {
            var user = await _loginService.CheckUserCredentials(login.Text, password.Password);
            if (user != null)
            {
                login.Text = "";
                password.Password = "";
                await _loginService.CreateLoginHistoryEntry(user, "Zalogowano!");
                Hide();
                _mainSystemWindow.LoginAndShow(user);
            }
            else
            {
                MessageBox.Show("Niepoprawne dane logowania!");
            }
        }

        /// <summary>
        /// Handles application exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closed(object sender, EventArgs e)
        {
            // exit application
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Checks if there are any users, and if not creates a default admin account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Initialized(object sender, EventArgs e)
        {
            CheckAdminAccount();
        }
        
        /// <summary>
        /// Checks if there are any users, and if not creates a default admin account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async Task CheckAdminAccount() {
            try { 
            
            
            if (await _loginService.CreateAdminUserIfNone())
            {
                MessageBox.Show("Utworzono konto administratora: admin/admin");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
