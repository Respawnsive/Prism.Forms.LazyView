using System;
using System.Reflection;
using Prism.DryIoc;
using Prism.Forms.LazyView.Sample.ViewModels;
using Prism.Forms.LazyView.Sample.Views;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Prism.Forms.LazyView.Sample
{
    [AutoRegisterForNavigation]
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
            //await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(TabHostPage)}?{KnownNavigationParameters.SelectedTab}={nameof(TopTabHostPage)}?{KnownNavigationParameters.SelectedTab}={nameof(TopStandardPage)}");
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                if (string.IsNullOrWhiteSpace(viewType.FullName))
                    return null;

                var viewModelAssemblyName = typeof(ViewModelBase).GetTypeInfo().Assembly.FullName;
                var viewModelNamespace = typeof(ViewModelBase).Namespace;
                var viewModelTypeName = viewType.Name.Replace("View", "ViewModel").Replace("Page", "ViewModel");
                var viewModelName = $"{viewModelNamespace}.{viewModelTypeName}, {viewModelAssemblyName}";
                var viewModelType = Type.GetType(viewModelName);
                return viewModelType;
            });
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LazyContentPage<LoadingSlowContentView, SlowContentView>, SlowContentViewModel>(nameof(SlowContentView)); // Default view on screen while lazy loading slow content view in background thread
            containerRegistry.RegisterForNavigation<LazyContentPage<TopSlowContentView>, TopSlowContentViewModel>(nameof(TopSlowContentView)); // Block ui while lazy loading slow content view on main thread
        }
    }
}
