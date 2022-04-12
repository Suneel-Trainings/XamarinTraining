using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Sample.Views
{
    public partial class SwitchCellTest : ContentPage
    {
        public SwitchCellTest()
        {
            InitializeComponent();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            DisplayAlert("","Tapped","OK");
        }
    }
}
