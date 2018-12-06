using Prism.Navigation;

namespace P42XamarinPrism.ViewModels
{
	public class ViewBViewModel : ViewModelBase
    {
        public ViewBViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "ViewB";
        }
    }
}
