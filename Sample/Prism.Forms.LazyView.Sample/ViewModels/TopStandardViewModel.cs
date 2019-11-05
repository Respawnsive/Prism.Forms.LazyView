using Prism.Commands;
using Prism.Forms.LazyView.Sample.Views;
using Prism.Navigation;
using Xamarin.Forms;

namespace Prism.Forms.LazyView.Sample.ViewModels
{
    public class TopStandardViewModel : ViewModelBase
    {
        public TopStandardViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Standard";
        }

        private DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteCommandName));

        async void ExecuteCommandName()
        {
            await NavigationService.NavigateAsync($"{nameof(OtherPage)}");
        }
    }
}
