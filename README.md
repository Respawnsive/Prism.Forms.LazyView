# Prism.Forms.LazyView
Lazy load Xamarin Forms views

Directly inspired by @andreinitescu work discribed here https://enginecore.blogspot.com/2019/01/xamarin-forms-lazy-load-tabs-in_10.html.
The original code has been adapted to Prism and published on Nuget.

### How to use it?

Install the Prism.Forms.LazyView nuget package and on a TabbedPage (e.g.):

* Add some references:
    
      xmlns:views="clr-namespace:YOUR.PROJECT.VIEWS.NAMESPACE;assembly=YOUR.PROJECT.ASSEMBLY"
      xmlns:lazyView="clr-namespace:Prism.Forms.LazyView;assembly=Prism.Forms.LazyView"

* Add some lazy tabs like this one:

      <lazyView:LazyContentPage Title="YOUR TAB NAME" x:TypeArguments="views:YOURCONTENTVIEW"/>
      
YOURCONTENTVIEW Forms ContentView will be created on tab click
Actually, it should work with any Prism control implementing MultiPageActiveAwareBehavior (e.g. Tabbed and Carousel)

More details on Sample project
