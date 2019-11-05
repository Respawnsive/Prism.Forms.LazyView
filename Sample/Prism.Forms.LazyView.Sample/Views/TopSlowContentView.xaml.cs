using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prism.Forms.LazyView.Sample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopSlowContentView : ContentView
    {
        public TopSlowContentView()
        {
            InitializeComponent();

            // Simulating a complex view
            // NEVER do this in real code
            Task.Delay(TimeSpan.FromSeconds(3)).Wait();
        }
    }
}