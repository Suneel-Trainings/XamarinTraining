using System;
using System.Reflection;
using Xamarin.Forms;

namespace TestSimulators.Renderers
{
    public class CustomPicker : Picker
    {
        public static readonly BindableProperty EnumTypeProperty =
            BindableProperty.Create(nameof(EnumType), typeof(Type), typeof(CustomPicker),
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    CustomPicker picker = (CustomPicker)bindable;

                    if (oldValue != null)
                    {
                        picker.ItemsSource = null;
                    }
                    if (newValue != null)
                    {
                        if (!((Type)newValue).GetTypeInfo().IsEnum)
                            throw new ArgumentException("EnumPicker: EnumType property must be enumeration type");

                        picker.ItemsSource = Enum.GetValues((Type)newValue);
                    }
                });

        public Type EnumType
        {
            set => SetValue(EnumTypeProperty, value);
            get => (Type)GetValue(EnumTypeProperty);
        }
    }
}
