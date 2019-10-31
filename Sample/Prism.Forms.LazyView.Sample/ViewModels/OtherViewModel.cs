using Prism.Navigation;

namespace Prism.Forms.LazyView.Sample.ViewModels
{
    public class OtherViewModel : ViewModelBase
    {
        public OtherViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Other";
        }
    }
}
