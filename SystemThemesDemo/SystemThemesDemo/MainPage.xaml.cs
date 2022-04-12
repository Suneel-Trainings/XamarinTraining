using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SystemThemesDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Detect the current system theme
            OSAppTheme currentTheme = Application.Current.RequestedTheme;
            lblCurrentTheme.Text = "Theme in use is: " + currentTheme.ToString();

            Application.Current.RequestedThemeChanged += (s, a) =>
            {
                // Respond to the theme change
            };
        }

        void LightTheme_Clicked(System.Object sender, System.EventArgs e)
        {
            //Set the current user theme
            Application.Current.UserAppTheme = OSAppTheme.Light;

            OSAppTheme currentTheme = Application.Current.RequestedTheme;
            lblCurrentTheme.Text = "Theme in use is: " + currentTheme.ToString();
        }

        void DarkTheme_Clicked(System.Object sender, System.EventArgs e)
        {
            //Set the current user theme
            Application.Current.UserAppTheme = OSAppTheme.Dark;

            OSAppTheme currentTheme = Application.Current.RequestedTheme;
            lblCurrentTheme.Text = "Theme in use is: " + currentTheme.ToString();
        }
    }
}
