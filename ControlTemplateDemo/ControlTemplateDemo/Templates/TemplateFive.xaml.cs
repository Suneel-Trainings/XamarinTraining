using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ControlTemplateDemo.Templates
{
    public partial class TemplateFive : StackLayout
    {
        public TemplateFive()
        {
            InitializeComponent();
            img.Source = new UriImageSource
            {
                Uri = new Uri("https://www.learningcontainer.com/wp-content/uploads/2020/08/Sample-PNG-File-for-Testing.png"),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(8,0,0,0)
            };
        }
    }
}
