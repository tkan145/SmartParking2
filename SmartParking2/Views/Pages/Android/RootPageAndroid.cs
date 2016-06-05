using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace SmartParking2
{
	public class RootPageAndroid : MasterDetailPage
	{
		Dictionary<int,MainNavigationPage> pages;

		public RootPageAndroid ()
		{
			pages = new Dictionary<int, MainNavigationPage> ();
			Master = new MenuPage (this);


			pages.Add (0, new MainNavigationPage (new Test ()));
			Detail = pages [0];
		}
	}
}

