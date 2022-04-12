using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TriggersDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //void entryEmail_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        //{
            
        //}

        void entryEmail_Completed(System.Object sender, System.EventArgs e)
        {
            var emailText = entryEmail.Text;

            bool isEmail = Regex.IsMatch(emailText, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (!isEmail)
            {
                DisplayAlert("Alert", "invalid email", "OK");
            }
        }
    }


    public class TriggerActionDo : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            var emailText = sender.Text;

            //Verify the given email is proper structure followed or not
            bool isEmail = Regex.IsMatch(emailText, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (isEmail)
            {
                // Yes
                // Set background to Green
                sender.BackgroundColor = Color.LightGreen;
            }
            else
            {
                // No
                // Set background to Red
                sender.BackgroundColor = Color.Red;
            }
        }
    }
}
