using Xamarin.Forms;

namespace Prism.Forms.LazyView.Behaviors
{
    public class LazyLoadContentPageBehavior : LazyLoadBehaviorBase<ContentPage>
    {
        protected override void SetContent(ContentPage contentPage, View view)
        {
            contentPage.Content = view;
        }
    }
}
