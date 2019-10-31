using Xamarin.Forms;

namespace Prism.Forms.LazyView.Behaviors
{
    public class LazyLoadContentViewBehavior : LazyLoadBehaviorBase<ContentView>
    {
        protected override void SetContent(ContentView element, View contentView)
        {
            element.Content = contentView;
        }
    }
}
