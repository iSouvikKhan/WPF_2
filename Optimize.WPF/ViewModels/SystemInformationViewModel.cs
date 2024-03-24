using System.Windows.Input;

namespace Optimize.WPF.ViewModels
{
    public class SystemInformationViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to System Information";

        public NavigationBarViewModel NavigationBarViewModel { get; }
        public ICommand NavigateDiskCleanupCommand { get; }
        public ICommand NavigateStartupManagerCommand { get; }
        public ICommand NavigateHomeCommand { get; }

        public SystemInformationViewModel(NavigationBarViewModel navigationBarViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
        }
    }
}
