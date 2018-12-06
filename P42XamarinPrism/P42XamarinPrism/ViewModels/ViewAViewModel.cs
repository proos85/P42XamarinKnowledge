using Prism.Navigation;

namespace P42XamarinPrism.ViewModels
{
	public class ViewAViewModel : ViewModelBase
	{
        public ViewAViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "ViewA";
        }
	}
}
