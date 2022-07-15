using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SystemKontrolka.Services;

namespace SystemKontrolka
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        /// <summary>
        /// Adds services to the ServiceCollection for later dependency injection.
        /// </summary>
        /// <param name="services"></param>
        private void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ILoginService, DbLoginService>();
            
            services.AddSingleton<LoginWindow>();
            services.AddSingleton<MainSystemWindow>();
            services.AddTransient<IServiceProvider>((c) => serviceProvider);
        }
        
        /// <summary>
        /// An event handler for application startup
        /// </summary>
        /// <param name="sender">The app</param>
        /// <param name="e">The event</param>
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var loginWindow = serviceProvider.GetService<LoginWindow>();
            loginWindow.Show();
        }
    }
}
