using Prism.Commands;
using Prism.Forms.LazyView.Sample.Views;
using Prism.Navigation;
using Xamarin.Forms;

namespace Prism.Forms.LazyView.Sample.ViewModels
{
    public class TopSlowContentViewModel : ViewModelBase
    {
        public TopSlowContentViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Block ui while lazy loading slow content view on main thread";
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
