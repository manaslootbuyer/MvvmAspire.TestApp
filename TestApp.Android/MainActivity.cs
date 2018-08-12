using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvvmAspire;
using MvvmAspire.Droid.Controls;
using TestApp.Helpers;

namespace TestApp.Droid
{
    [Activity(Label = "TestApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            AppHelper.FastCellCache = FastCellCache.Instance;
            base.OnCreate(bundle);

            MvvmAspire.Controls.UIHelper.Drawable = typeof(TestApp.Droid.Resource.Drawable);
            MvvmAspire.Controls.UIHelper.Layout = typeof(Resource.Layout);
            MvvmAspire.Controls.UIHelper.Id = typeof(Resource.Id);
            MvvmAspire.Controls.UIHelper.Context = this;

            AppBootstrap.Init();
            Bootstrap.Init(this);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

