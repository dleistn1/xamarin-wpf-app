using Prism.Navigation;
using XamarinSample.UI.ViewModels;

namespace XamarinSample.UI.Main.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}