using System;
using Xamarin.Forms;

namespace SmartParking2
{
	public class MainNavigationPage : NavigationPage
	{
		public MainNavigationPage (Page root) : base (root)
		{
			Init ();
			Title = root.Title;
			Icon = root.Icon;
		}

		void Init ()
		{
			if (Device.OS == TargetPlatform.iOS) {
				BarBackgroundColor = Color.FromHex ("FAFAFA");
			} else {   
				BarBackgroundColor = (Color)Application.Current.Resources ["Primary"];
				BarTextColor = (Color)Application.Current.Resources ["NavigationText"];
			}
		}
	}
}

