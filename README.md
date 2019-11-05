# Prism.Forms.LazyView
Lazy load Xamarin Forms views with Prism

Directly inspired by @andreinitescu work discribed here https://enginecore.blogspot.com/2019/01/xamarin-forms-lazy-load-tabs-in_10.html.
The original code has been adapted to Prism and published on Nuget.

### How to use it?

Install the Prism.Forms.LazyView nuget package and on a TabbedPage (e.g.):

* Add some references:
    
      xmlns:views="clr-namespace:YOUR.PROJECT.VIEWS.NAMESPACE;assembly=YOUR.PROJECT.ASSEMBLY"
      xmlns:lazyView="clr-namespace:Prism.Forms.LazyView;assembly=Prism.Forms.LazyView"

* Add some lazy tabs like this one:

      <lazyView:LazyContentPage Title="YOUR TAB NAME" x:TypeArguments="views:YOUR_CONTENT_VIEW"/>
      
* or with background thread loading
 
      <lazyView:LazyContentPage Title="YOUR TAB NAME" x:TypeArguments="views:YOUR_LOADING_VIEW,views:YOUR_CONTENT_VIEW"/>
      
* Register your lazy page for navigartion

      containerRegistry.RegisterForNavigation<LazyContentPage<YOUR_CONTENT_VIEW>, YOUR_CONTENT_VIEWMODEL>(nameof(YOUR_CONTENT_VIEW));
      
* or with background thread loading
 
      containerRegistry.RegisterForNavigation<LazyContentPage<YOUR_LOADING_VIEW,YOUR_CONTENT_VIEW>, YOUR_CONTENT_VIEWMODEL>(nameof(YOUR_CONTENT_VIEW));
      
YOUR_CONTENT_VIEW should be a Xamarin.Forms ContentView and will be created once tab clicked

YOUR_LOADING_VIEW should be a Xamarin.Forms ContentView and will be displayed while lazy loading YOUR_CONTENT_VIEW in a background thread

Actually, it should work with any Prism control implementing MultiPageActiveAwareBehavior (e.g. Tabbed and Carousel)

More details on Sample project
