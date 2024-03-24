using System.Windows.Input;

namespace Optimize.WPF.ViewModels
{
    public class DiskCleanupViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to Disk Cleanup";
        public NavigationBarViewModel NavigationBarViewModel { get; }
        public ICommand NavigateStartupManagerCommand { get; }
        public ICommand NavigateSystemInformationCommand { get; }
        public ICommand NavigateHomeCommand { get; }

        public DiskCleanupViewModel(NavigationBarViewModel navigationBarViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
        }
    }
}
