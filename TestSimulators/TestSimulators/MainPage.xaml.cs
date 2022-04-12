using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestSimulators
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //this.BindingContext = new MainPageViewModel();
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

    

    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _imgtitle;
        public string ImgTitle
        {
            get
            {
                return _imgtitle;
            }
            set
            {
                if (_imgtitle != value)
                {
                    _imgtitle = value;
                    NotifyPropertyChanged(nameof(ImgTitle));
                }
            }
        }

        public MainPageViewModel()
        {
            ImgTitle = "http://eoimages.gsfc.nasa.gov/images/imagerecords/57000/57723/globe_west_2048.jpg";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
