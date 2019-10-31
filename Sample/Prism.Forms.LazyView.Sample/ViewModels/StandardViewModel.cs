using Prism.Navigation;

namespace Prism.Forms.LazyView.Sample.ViewModels
{
    public class StandardViewModel : ViewModelBase
    {
        public StandardViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Standard";
        }
    }
}
