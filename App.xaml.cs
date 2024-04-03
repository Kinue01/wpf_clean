using clean_arch.View.Services.Implementations;
using clean_arch.View.Services.Interfaces;
using clean_arch.View.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using clean_arch.View.Views;
using clean_arch.Infrastructure.EntityFramework.Models;

namespace clean_arch.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly ServiceProvider serviceProvider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton(provider => new MainWindow
            {
                DataContext = provider.GetRequiredService<NavigationViewModel>()
            });
            services.AddSingleton<NavigationViewModel>();
            services.AddSingleton<ItemsViewModel>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<UsersViewModel>();
            services.AddSingleton<ItemAddViewModel>();
            services.AddSingleton<INavigationService, NavigationService>();
            services.AddDbContextFactory<BikeMarketContext>();
            services.AddHttpClient();

            services.AddSingleton<Func<Type, ObservableObject>>(serviceProvider => viewModelType => (ObservableObject)serviceProvider.GetRequiredService(viewModelType));

            serviceProvider = services.BuildServiceProvider();
        }



        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
            base.OnStartup(e);
        }
    }

}
