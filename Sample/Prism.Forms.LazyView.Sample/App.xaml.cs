using Prism.DryIoc;
using Prism.Forms.LazyView.Sample.ViewModels;
using Prism.Forms.LazyView.Sample.Views;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Prism.Forms.LazyView.Sample
{
    //[AutoRegisterForNavigation]
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(TabHostPage)}");
            //await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(TabHostPage)}?{KnownNavigationParameters.SelectedTab}={nameof(SlowContentView)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TabHostPage, TabHostViewModel>();
            containerRegistry.RegisterForNavigation<OtherPage, OtherViewModel>();
            containerRegistry.RegisterForNavigation<StandardPage, StandardViewModel>();
            containerRegistry.RegisterForNavigation<LazyContentPage<SlowContentView>, SlowContentViewModel>(nameof(SlowContentView));
        }
    }
}
