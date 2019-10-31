using System.Threading.Tasks;
using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;

namespace Prism.Forms.LazyView.Sample.ViewModels
{
    public class ViewModelBase : BindableBase, IAutoInitialize,
        IInitialize,
        IInitializeAsync,
        INavigatedAware,
        IPageLifecycleAware,
        IDestructible,
        IConfirmNavigationAsync
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }

        public virtual Task InitializeAsync(INavigationParameters parameters)
        {
            return Task.CompletedTask;
        }

        public virtual void OnAppearing()
        {

        }

        public virtual void OnDisappearing()
        {

        }

        public virtual Task<bool> CanNavigateAsync(INavigationParameters parameters)
        {
            return Task.FromResult(true);
        }
    }
}
