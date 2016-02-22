using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace TabbedTest.Droid
{
	[Activity (Label = "TabbedTest.Droid", Icon = "@drawable/icon", MainLauncher = true, Theme = "@style/MyTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			//			Xamarin.Insights.Initialize (global::TabbedTest.Droid.XamarinInsights.ApiKey, this);
	
			FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
			FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;
	
			base.OnCreate (bundle);
	
			global::Xamarin.Forms.Forms.Init (this, bundle);
	
			LoadApplication (new App ());
		}
	}

	//	[Activity (Label = "TabbedTest.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	//	public class MainActivity : FormsApplicationActivity
	//	{
	//		protected override void OnCreate (Bundle bundle)
	//		{
	//			base.OnCreate (bundle);
	//
	//			global::Xamarin.Forms.Forms.Init (this, bundle);
	//
	//			LoadApplication (new App ());
	//		}
	//	}
}
