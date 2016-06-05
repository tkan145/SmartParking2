using System;
using Xamarin.Forms;

namespace SmartParking2
{
	public class RootPageiOS : TabbedPage
	{
		public RootPageiOS ()
		{
			NavigationPage.SetHasNavigationBar (this, false);
			//Children.Add (new MainNavigationPage (new MainPage ()));
			Children.Add (new MainNavigationPage (new Test ()));
			Children.Add (new MainNavigationPage (new MapPage ()));
		}
	}
}

