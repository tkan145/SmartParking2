using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace SmartParking2
{
	public partial class LocationViewDetailPage : ContentPage
	{
		LocationDetailsViewModel vm;

		public LocationViewDetailPage (Location lo)
		{
			InitializeComponent ();
			BindingContext = vm = new LocationDetailsViewModel (lo);
//			ParkingDirections.Clicked += async (sender, e) => {
//				var location = vm.Location.Address;
//				if (location == null)
//					return;
//				await Navigation.PushAsync (new LocationViewDetailPage (location));
//			};
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			if (MyMap.Pins.Count > 0)
				return;

			var position = new Position (vm.Location.Latitude, vm.Location.Longitude);
			MyMap.MoveToRegion (new MapSpan (position, 0.02, 0.02));
			MyMap.Pins.Add (new Pin {
				Type = PinType.Place,
				Label = "Label",
				Address = vm.Location.Address,
				Position = position
			});
		}

		void OnButtonClicked (object sender, EventArgs args)
		{
			Booking.Navigation.PushModalAsync (new BookingPage (vm.Location));
		}
	}
}

