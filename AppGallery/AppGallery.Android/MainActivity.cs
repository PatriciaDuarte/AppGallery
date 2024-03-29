﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AppGallery.Droid
{
    [Activity(Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            Xamarin.Forms.Forms.SetFlags(new string[] {
                "RadioButton_Experimental",
                "SwipeView_Experimental",
                "MediaElement_Experimental",
                "CarouselView_Experimental",
                "IndicatorView_Experimental",
                "AppTheme_Experimental",
                "Expander_Experimental",
            });
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}