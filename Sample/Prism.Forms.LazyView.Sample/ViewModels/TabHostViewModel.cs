using Prism.Navigation;

namespace Prism.Forms.LazyView.Sample.ViewModels
{
    public class TabHostViewModel : ViewModelBase
    {
        public TabHostViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "TabHost";
        }
    }
}
