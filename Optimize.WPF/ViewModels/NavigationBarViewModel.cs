using Optimize.WPF.Commands;
using Optimize.WPF.Services;
using System.Windows.Input;

namespace Optimize.WPF.ViewModels
{
    public class NavigationBarViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateDiskCleanupCommand { get; }
        public ICommand NavigateStartupManagerCommand { get; }
        public ICommand NavigateSystemInformationCommand { get; }

        public NavigationBarViewModel(NavigationService<HomeViewModel> homeNavigationService,
            NavigationService<DiskCleanupViewModel> diskCleanupNavigationService,
            NavigationService<StartupManagerViewModel> startupManagerNavigationService,
            NavigationService<SystemInformationViewModel> systemInformationNavigationService
            )
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
            NavigateDiskCleanupCommand = new NavigateCommand<DiskCleanupViewModel>(diskCleanupNavigationService);
            NavigateStartupManagerCommand = new NavigateCommand<StartupManagerViewModel>(startupManagerNavigationService);
            NavigateSystemInformationCommand = new NavigateCommand<SystemInformationViewModel>(systemInformationNavigationService);
        }
    }
}
