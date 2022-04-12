using System;
using Xamarin.Forms;

namespace ListviewDemo
{
    public class StudentDTSelector : DataTemplateSelector
    {
        public StudentDTSelector()
        {
        }

        public DataTemplate JuniorTemplate { get; set; }
        public DataTemplate SeniorTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Student)item).Standard <= 8 ? JuniorTemplate : SeniorTemplate;
        }
    }
}
