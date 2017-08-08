using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace pharm_dbb.Droid
{
    [Activity(Theme = "@android:style/Theme.Holo.Light", Label = "MCA", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {




        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            this.ActionBar.SetIcon(Android.Resource.Color.Transparent);
            
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

