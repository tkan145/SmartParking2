using System;
using System.Collections.Generic;

using Xamarin.Forms;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace SmartParking2
{
	public partial class App : Application
	{
		public static App current;
		public static double ScreenHeight;
		public static double ScreenWidth;
		private readonly static Locator _locator;

		public App ()
		{
			current = this;
			InitializeComponent ();
			// The root page of your application
			MainPage = new Test ();

			var nav = new NavigationService ();
			nav.Configure (Locator.LocationPageKey, typeof(Test));
			nav.Configure (Locator.LocationDetailPageKey, typeof(LocationViewDetailPage));

			SimpleIoc.Default.Register<INavigationService> (() => nav);


			switch (Device.OS) {
			case TargetPlatform.Android:
				MainPage = new Test ();
				//MainPage = new RootPageAndroid ();
				break;
			case TargetPlatform.iOS:
				var LocationListPage = new MainNavigationPage (new RootPageiOS ());
				nav.Initialize (LocationListPage);
				//MainPage = new MainNavigationPage (new RootPageiOS ());
				MainPage = LocationListPage;
				//MainPage = new LocationsPage ();
				break;
			default:
				throw new NotImplementedException ();
			}
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

