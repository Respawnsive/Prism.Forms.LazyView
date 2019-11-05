using System;
using Prism.Forms.LazyView.Behaviors;
using Xamarin.Forms;

namespace Prism.Forms.LazyView
{
    public class LazyContentView<TContentView> : ContentView, IActiveAware where TContentView : View
    {
        public event EventHandler IsActiveChanged;

        public LazyContentView()
        {
            Behaviors.Add(new LazyLoadContentViewBehavior
            {
                ContentTemplate = new DataTemplate(typeof(TContentView))
            });
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

    public class LazyContentView<TLoadingView, TContentView> : ContentView, IActiveAware where TLoadingView : View where TContentView : View
    {
        public event EventHandler IsActiveChanged;

        public LazyContentView()
        {
            Behaviors.Add(new LazyLoadContentViewBehavior
            {
                LoadingTemplate = new DataTemplate(typeof(TLoadingView)),
                ContentTemplate = new DataTemplate(typeof(TContentView))
            });
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
