using System;
using Prism.Forms.LazyView.Behaviors;
using Xamarin.Forms;

namespace Prism.Forms.LazyView
{
    public class LazyContentPage<TContentView> : ContentPage, IActiveAware where TContentView : View
    {
        public event EventHandler IsActiveChanged;

        public LazyContentPage()
        {
            Behaviors.Add(new LazyLoadContentPageBehavior{ ContentTemplate = new DataTemplate(typeof(TContentView))});
        }

        bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set
            {
                if (_isActive != value)
                {
                    _isActive = value;
                    IsActiveChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
