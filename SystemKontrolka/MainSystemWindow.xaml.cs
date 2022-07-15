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

namespace SystemKontrolka
{
    /// <summary>
    /// Interaction logic for MainSystemWindow.xaml
    /// </summary>
    public partial class MainSystemWindow : Window
    {
        private readonly IServiceProvider _serviceProvider;
            
        public MainSystemWindow(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
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
    }
}
