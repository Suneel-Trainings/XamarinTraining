using System;
using System.Collections.Generic;
using TestSimulators.Themes;
using Xamarin.Forms;

namespace TestSimulators
{
    public partial class TestControls : ContentPage
    {
        List<string> lstThemes = new List<string>
        {
            "Light",
            "Dark"
        };
        public TestControls()
        {
            InitializeComponent();
            pickerTheme.ItemsSource = lstThemes;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            //var userName = entryUserName.Text;
            //var password = entryPassword.Text;
            //var verifyPassword = entryVerifyPassword.Text;
            //var email = entryEmail.Text;
            //var mobile = entryMobile.Text;

            //if (string.IsNullOrEmpty(userName))
            //{
            //    DisplayAlert("Alert", "Please enter your username", "OK");
            //}
            //else if (string.IsNullOrEmpty(password))
            //{
            //    DisplayAlert("Alert", "Please enter your password", "OK");
            //}
            //else if(string.IsNullOrEmpty(verifyPassword))
            //{
            //    DisplayAlert("Alert", "Please enter your verify password", "OK");
            //}
            //else if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(verifyPassword))
            //{
            //    if (!password.Equals(verifyPassword))
            //    {
            //        DisplayAlert("Alert", "Please enter same password and verify password", "OK");
            //    }
            //    else if (string.IsNullOrEmpty(email))
            //    {
            //        DisplayAlert("Alert", "Please enter your email", "OK");
            //    }
            //    else if (!email.Contains("@"))
            //    {
            //        DisplayAlert("Alert", "Please enter a valid email", "OK");
            //    }
            //    else if (string.IsNullOrEmpty(mobile))
            //    {
            //        DisplayAlert("Alert", "Please enter your mobile", "OK");
            //    }
            //    else if (mobile.Length != 10)
            //    {
            //        DisplayAlert("Alert", "Please enter a valid mobile", "OK");
            //    }
            //}

            Navigation.PushAsync(new MainPage());
            
        }

        void OnPickerSelectionChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            string theme = (string)picker.SelectedItem;

            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;

            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();

                switch (theme)
                {
                    case "Dark":
                        mergedDictionaries.Add(new DarkTheme());
                        break;
                    case "Light":
                    default:
                        mergedDictionaries.Add(new LightTheme());
                        break;
                }
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
