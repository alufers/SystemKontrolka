using Microsoft.EntityFrameworkCore;
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
using SystemKontrolka.Models;
using Microsoft.Extensions.DependencyInjection;

namespace SystemKontrolka
{
    /// <summary>
    /// Interaction logic for AddReportWindow.xaml
    /// </summary>
    public partial class AddReportWindow : Window
    {

        private readonly KontrolkaDbContext _kontrolkaDbContext;
        private User _user;
        private readonly IServiceProvider _serviceProvider;

        public AddReportWindow(KontrolkaDbContext kontrolkaDbContext, IServiceProvider serviceProvider)
        {
            _kontrolkaDbContext = kontrolkaDbContext;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the IsVisibleChanged of the window and loads the data for the combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LoadPartsOptions();
        }

        /// <summary>
        /// Shows the form with the given user as the author
        /// </summary>
        /// <param name="user"></param>
        public void ShowForUser(User user)
        {
            _user = user;
            Show();
        }

        /// <summary>
        /// Loads parts options from the db to the combo box
        /// </summary>
        public async Task LoadPartsOptions()
        {
            var parts = await _kontrolkaDbContext.Parts.ToListAsync();
            PartSelectionComboBox.ItemsSource = parts;
        }

        /// <summary>
        /// Handles the SelectionChanged event from the combo box and displays the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PartSelectionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PartSelectionComboBox.SelectedItem != null)
            {
                var part = PartSelectionComboBox.SelectedItem as Part;
                WeightHint.Content = "Wyamagana waga: " + part.Weight.ToString();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Saves the report to the database.
        /// </summary>
        /// <returns></returns>
        public async Task Save()
        {
            try
            {


                var report = new Report
                {
                    User = _user,
                    Part = PartSelectionComboBox.SelectedItem as Part,
                    Description = Description.Text,
                    Date = DateTime.Now
                };
                _kontrolkaDbContext.Reports.Add(report);
                await _kontrolkaDbContext.SaveChangesAsync();
                await _serviceProvider.GetService<MainSystemWindow>().LoadReports();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the window closing event, hides the window instedad of removing it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
