using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Navigation;
using P42XamarinPrism.Helpers;
using Prism.Commands;
using Prism.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace P42XamarinPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IPageDialogService _pageDialogService;
        private bool _isAwesomeButtonEnabled = false;
        public bool IsAwesomeButtonEnabled
        {
            get => _isAwesomeButtonEnabled;
            set => SetProperty(ref _isAwesomeButtonEnabled, value);
        }

        public ICommand AwesomeButtonCommand { get; set; }
        public ICommand NetworkStateCommand { get; set; }

        public MainPageViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService)
            : base(navigationService)
        {
            _pageDialogService = pageDialogService;

            Title = Secrets.MainLabel;

            AwesomeButtonCommand = new DelegateCommand(
                        async() => await PerformAwesomeButtonLogic(), 
                        CanPerformAwesomeButtonLogic)
                .ObservesProperty(() => IsAwesomeButtonEnabled)
                ;

            NetworkStateCommand = new DelegateCommand(async() => await NetworkStateActionAsync());

            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                IsAwesomeButtonEnabled = true;
                return false;
            });
        }

        private async Task NetworkStateActionAsync()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                await _pageDialogService.DisplayAlertAsync("Network state", "Has Access", "OK");
            }
        }

        private bool CanPerformAwesomeButtonLogic()
        {
            return IsAwesomeButtonEnabled;
        }

        private async Task PerformAwesomeButtonLogic()
        {
            await _pageDialogService.DisplayAlertAsync(Secrets.HelloWorldMessage, Secrets.HelloWorldMessage, "OK");
        }
    }
}
