using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Reflection;
using PCLStorage;
using Plugin.EmbeddedResource;
using System.Diagnostics;
using MvvmHelpers;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace SmartParking2
{
	public partial class Test : ContentPage
	{
		LocationViewModel vm;

		public Test ()
		{
			InitializeComponent ();
			BindingContext = vm = new LocationViewModel ();
			ListViewLocations.ItemSelected += async (sender, e) => {
				var location = ListViewLocations.SelectedItem as Location;
				if (location == null)
					return;
				await Navigation.PushAsync (new LocationViewDetailPage (location));


				ListViewLocations.SelectedItem = null;
			};

		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
		}
	}
}

