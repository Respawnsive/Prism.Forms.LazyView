using System;
using Xamarin.Forms;

namespace Prism.Forms.LazyView.Behaviors
{
    /// <summary>
    /// This behavior lazy loads content when its visual element is activated
    /// </summary>
    /// <typeparam name="TVisualElement">A visual element</typeparam>
    public abstract class LazyLoadBehaviorBase<TVisualElement> : Behavior<TVisualElement>
        where TVisualElement : VisualElement
    {
        public DataTemplate ContentTemplate { get; set; }

        protected override void OnAttachedTo(TVisualElement element)
        {
            base.OnAttachedTo(element);

            if(element is IActiveAware activeAwareElement)
                activeAwareElement.IsActiveChanged += OnIsActiveChanged;
        }

        protected override void OnDetachingFrom(TVisualElement element)
        {
            if (element is IActiveAware activeAwareElement)
                activeAwareElement.IsActiveChanged -= OnIsActiveChanged;

            base.OnDetachingFrom(element);
        }

        void OnIsActiveChanged(object sender, EventArgs e)
        {
            var element = (TVisualElement)sender;
            element.Behaviors.Remove(this);

            SetContent(element, (View)ContentTemplate.CreateContent());
        }

        protected abstract void SetContent(TVisualElement element, View contentView);
    }
}
