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
    public partial class LoadingSlowContentView : ContentView
    {
        public LoadingSlowContentView()
        {
            InitializeComponent();
        }
    }
}