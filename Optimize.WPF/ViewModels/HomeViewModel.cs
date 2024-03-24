using System.Windows.Input;

namespace Optimize.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to PC Optimization Dashboard";

        public NavigationBarViewModel NavigationBarViewModel { get; }
        public ICommand NavigateDiskCleanupCommand { get; }
        public ICommand NavigateStartupManagerCommand { get; }
        public ICommand NavigateSystemInformationCommand { get; }

        public HomeViewModel(NavigationBarViewModel navigationBarViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
        }
    }
}
