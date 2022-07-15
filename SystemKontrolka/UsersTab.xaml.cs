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

namespace SystemKontrolka
{
    /// <summary>
    /// Interaction logic for UsersTab.xaml
    /// </summary>
    public partial class UsersTab : UserControl
    {
        private readonly AddUserWindow _addUserWindow;

        public UsersTab(AddUserWindow addUserWindow)
        {
            InitializeComponent();
            this._addUserWindow = addUserWindow;
        }
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _addUserWindow.Show();
        }
    }
}
