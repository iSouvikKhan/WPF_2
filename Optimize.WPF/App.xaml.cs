using Optimize.WPF.Services;
using Optimize.WPF.Stores;
using Optimize.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Optimize.WPF
{
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly NavigationBarViewModel _navigationBarViewModel;

        public App()
        {
            _navigationStore = new NavigationStore();
            _navigationBarViewModel = new NavigationBarViewModel(
                CreateHomeNavigationService(),
                CreateDiskCleanupNavigationService(),
                CreateStartupManagerNavigationService(),
                CreateSystemInformationNavigationService()
                );
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationBarViewModel);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();


            base.OnStartup(e);
        }

        private NavigationService<HomeViewModel> CreateHomeNavigationService()
        {
            return new NavigationService<HomeViewModel>(
                _navigationStore,
                () => new HomeViewModel(_navigationBarViewModel));
        }

        private NavigationService<DiskCleanupViewModel> CreateDiskCleanupNavigationService()
        {
            return new NavigationService<DiskCleanupViewModel>(_navigationStore, () => new DiskCleanupViewModel(_navigationBarViewModel));
        }

        private NavigationService<StartupManagerViewModel> CreateStartupManagerNavigationService()
        {
            return new NavigationService<StartupManagerViewModel>(_navigationStore, () => new StartupManagerViewModel(_navigationBarViewModel));
        }

        private NavigationService<SystemInformationViewModel> CreateSystemInformationNavigationService()
        {
            return new NavigationService<SystemInformationViewModel>(_navigationStore, () => new SystemInformationViewModel(_navigationBarViewModel));
        }
    }
}
