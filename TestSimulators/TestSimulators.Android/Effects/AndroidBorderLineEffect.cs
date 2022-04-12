using System;
using System.ComponentModel;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using TestSimulators.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("MyCompanyName")]
[assembly: ExportEffect(typeof(AndroidBorderLineEffect), "BorderLineEffect")]
namespace TestSimulators.Droid.Effects
{
    public class AndroidBorderLineEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Android.Graphics.Color borderColor = Android.Graphics.Color.Orange;
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Control.BackgroundTintList = ColorStateList.ValueOf(borderColor);
            }
            else
            {
                Control.Background.SetColorFilter(borderColor, PorterDuff.Mode.Src);
            }
        }

        protected override void OnDetached()
        {
            
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
        }
    }
}
