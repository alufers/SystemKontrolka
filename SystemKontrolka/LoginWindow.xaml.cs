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

        private async Task DoLogin()
        {
            if (await _loginService.CheckUserCredentials(login.Text, password.Password))
            {
                Hide();
                _mainSystemWindow.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane logowania!");
            }
        }

        
    }
}
