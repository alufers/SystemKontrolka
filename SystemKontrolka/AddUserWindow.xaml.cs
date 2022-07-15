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
using Microsoft.Extensions.DependencyInjection;

namespace SystemKontrolka
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        private readonly KontrolkaDbContext _dbContext;
        private readonly IServiceProvider _serviceProvider;

        private User user = new User
        {
            Username = "",
            Password = "",
            CanEditDefectTypes = false,
            CanEditParts = false,
            CanEditReports = false,
            CanEditUsers = false,
        };

        public AddUserWindow(KontrolkaDbContext dbContext, IServiceProvider serviceProvider)
        {
            _dbContext = dbContext;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void SaveUserButton_Click(object sender, RoutedEventArgs e)
        {
            SaveUser();
        }

        /// <summary>
        /// Saves the user in the database
        /// </summary>
        /// <returns></returns>
        private async Task SaveUser()
        {
            try
            {



                if (PasswordRepeatTextBox.Text == PasswordTextBox.Text)
                {
                    user.Username = UserNameTextBox.Text;
                    user.Password = PasswordTextBox.Text;
                    user.CanEditDefectTypes = CanEditDefectTypesCheckBox.IsChecked.Value;
                    user.CanEditParts = CanEditPartsCheckBox.IsChecked.Value;
                    user.CanEditReports = CanEditReportsCheckBox.IsChecked.Value;
                    user.CanEditUsers = CanEditUsersCheckBox.IsChecked.Value;
                    _dbContext.Users.Add(user);
                    await _dbContext.SaveChangesAsync();
                    user = new User
                    {
                        Username = "",
                        Password = "",
                        CanEditDefectTypes = false,
                        CanEditParts = false,
                        CanEditReports = false,
                        CanEditUsers = false,
                    };
                    await _serviceProvider.GetService<MainSystemWindow>().LoadUsers();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hasła nie są takie same");
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
    }
}
