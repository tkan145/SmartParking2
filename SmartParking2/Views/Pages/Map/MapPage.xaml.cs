using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace SmartParking2
{
	public partial class MapPage : ContentPage
	{
		LocationViewModel vm;

		public MapPage ()
		{
			
			InitializeComponent ();
			BindingContext = vm = new LocationViewModel ();



		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			if (myMap.Pins.Count > 0)
				return;

			foreach (Location lc in vm.Locations) {
				var position = new Position (lc.Latitude, lc.Longitude);
				myMap.MoveToRegion (new MapSpan (position, 0.02, 0.02));
				myMap.Pins.Add (new Pin {
					Type = PinType.Place,
					Label = "Casdasd",
					Address = lc.Address,
					Position = position
				});
			}
		}
	}
}

