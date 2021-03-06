﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prism.Forms.LazyView.Sample.Views
{
    public partial class SlowContentView : ContentView
    {
        public SlowContentView()
        {
            InitializeComponent();

            // Simulating a complex view
            // NEVER do this in real code
            Task.Delay(TimeSpan.FromSeconds(3)).Wait();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            LazyContentView.IsActive = !LazyContentView.IsActive;
        }
    }
}