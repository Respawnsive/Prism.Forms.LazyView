using Xamarin.Forms;

namespace Prism.Forms.LazyView.Behaviors
{
    public class LazyLoadContentPageBehavior : LazyLoadBehaviorBase<ContentPage>
    {
        protected override void SetContent(ContentPage page, View contentView)
        {
            page.Content = contentView;
        }
    }
}
