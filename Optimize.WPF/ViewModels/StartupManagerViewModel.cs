using System.Windows.Input;

namespace Optimize.WPF.ViewModels
{
    public class StartupManagerViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to Startup Manager";

        public NavigationBarViewModel NavigationBarViewModel { get; }
        public ICommand NavigateDiskCleanupCommand { get; }
        public ICommand NavigateSystemInformationCommand { get; }
        public ICommand NavigateHomeCommand { get; }

        public StartupManagerViewModel(NavigationBarViewModel navigationBarViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
        }
    }
}
