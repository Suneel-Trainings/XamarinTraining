using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ControlTemplateDemo.Controls
{
    public partial class CardView : ContentView, IDisposable
    {
        public CardView()
        {
            InitializeComponent();
            this.BindingContextChanged += CardView_BindingContextChanged;
        }

        public void Dispose()
        {
            this.BindingContextChanged -= CardView_BindingContextChanged;
        }

        private void CardView_BindingContextChanged(object sender, EventArgs e)
        {
            // your implementation
        }
    }
}
