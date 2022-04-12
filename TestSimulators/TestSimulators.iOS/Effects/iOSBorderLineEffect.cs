using System;
using System.ComponentModel;
using TestSimulators.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("MyCompanyName")]
[assembly: ExportEffect(typeof(iOSBorderLineEffect), "BorderLineEffect")]
namespace TestSimulators.iOS.Effects
{
    public class iOSBorderLineEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            this.Control.Layer.BorderColor = UIColor.Orange.CGColor;
            this.Control.Layer.BorderWidth = new nfloat(0.9);
            this.Control.Layer.CornerRadius = 5;
        }

        protected override void OnDetached()
        {
            this.Control.Layer.BorderColor = UIColor.Gray.CGColor;
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
        }
    }
}
