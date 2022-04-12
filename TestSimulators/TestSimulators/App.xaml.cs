using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestSimulators
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TestControls())
            {
                BarBackgroundColor = Color.BlueViolet,
                BarTextColor = Color.Red
            }; //MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
