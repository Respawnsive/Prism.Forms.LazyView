using Prism.AppModel;
using Xamarin.Forms;

namespace Prism.Forms.LazyView.Behaviors
{
    public class LazyLoadContentViewBehavior : LazyLoadBehaviorBase<ContentView>
    {
        protected override void SetContent(ContentView contentView, View view)
        {
            ((view as ContentView)?.BindingContext as IPageLifecycleAware)?.OnAppearing();
            contentView.Content = view;
        }
    }
}
