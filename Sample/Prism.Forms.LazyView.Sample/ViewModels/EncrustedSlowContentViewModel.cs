using Prism.Navigation;

namespace Prism.Forms.LazyView.Sample.ViewModels
{
    public class EncrustedSlowContentViewModel : SlowContentViewModel
    {
        public EncrustedSlowContentViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
