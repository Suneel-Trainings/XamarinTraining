using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlTemplateDemo.Templates;
using ControlTemplateDemo.ViewModels;
using Xamarin.Forms;

namespace ControlTemplateDemo
{
    public partial class MainPage : ContentPage
    {
        int templateIndex = 0;

        //Templates
        ControlTemplate template1 = new ControlTemplate(typeof(TemplateOne));
        ControlTemplate template2 = new ControlTemplate(typeof(TemplateTwo));
        ControlTemplate template3 = new ControlTemplate(typeof(TemplateThree));
        ControlTemplate template4 = new ControlTemplate(typeof(TemplateFour));
        ControlTemplate template5 = new ControlTemplate(typeof(TemplateFive));

        public MainPage()
        {

            StackLayout stack = new StackLayout();

            InitializeComponent();
            BindingContext = new MainViewModel();
            picker.SelectedIndex = 0;
            this.ControlTemplate = template5;
        }

        // Assume that it doesn't exists
        void SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var index = picker.SelectedIndex;
            if (index != templateIndex)
            {
                switch (index)
                {
                    case 0:
                        ControlTemplate = template1;
                        break;
                    case 1:
                        ControlTemplate = template2;
                        break;
                    case 2:
                        ControlTemplate = template3;
                        break;
                    case 3:
                        ControlTemplate = template4;
                        break;
                    case 4:
                        ControlTemplate = template5;
                        break;
                }

                templateIndex = index;
            }
        }
    }
}
