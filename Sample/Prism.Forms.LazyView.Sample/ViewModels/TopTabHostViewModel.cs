using Prism.Navigation;

namespace Prism.Forms.LazyView.Sample.ViewModels
{
    public class TopTabHostViewModel : ViewModelBase
    {
        public TopTabHostViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Top";
        }
    }
}
