using Android.App;
using Android.Content.PM;
using Android.OS;
using Prism;
using Prism.Ioc;

namespace Sample.Droid
{
    [Activity(Label = "Sample.Droid", Icon = "@drawable/icon",Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.SetFlags("FastRenderers_Experimental");
			 global::Xamarin.Forms.Forms.Init(this, bundle);
            AiForms.Effects.Droid.Effects.Init();
            Xamarin.Forms.Svg.Droid.SvgImage.Init(this);
            AiForms.Renderers.Droid.SettingsViewInit.Init();


			LoadApplication(new App(new AndroidInitializer()));
		}
	}

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
