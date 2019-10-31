using Prism.Commands;
using Prism.Forms.LazyView.Sample.Views;
using Prism.Navigation;

namespace Prism.Forms.LazyView.Sample.ViewModels
{
    public class SlowContentViewModel : ViewModelBase
    {
        public SlowContentViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "SlowContentView";
        }

        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteCommandName));

        async void ExecuteCommandName()
        {
            await NavigationService.NavigateAsync($"{nameof(OtherPage)}");
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }
    }
}
