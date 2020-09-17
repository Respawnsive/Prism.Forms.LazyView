using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prism.Forms.LazyView.Sample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EncrustedSlowContentView : ContentView
    {
        public EncrustedSlowContentView()
        {
            InitializeComponent();

            // Simulating a complex view
            // NEVER do this in real code
            Task.Delay(TimeSpan.FromSeconds(3)).Wait();
        }
    }
}