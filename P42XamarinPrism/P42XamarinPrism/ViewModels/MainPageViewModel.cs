using Prism.Navigation;
using P42XamarinPrism.Helpers;

namespace P42XamarinPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = Secrets.MainLabel;
        }
    }
}
