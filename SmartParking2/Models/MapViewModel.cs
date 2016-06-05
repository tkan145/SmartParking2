using System;
using MvvmHelpers;
using Xamarin.Forms.Maps;
using System.Collections.Generic;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;

namespace SmartParking2
{
	public class MapViewModel :BaseViewModel
	{
		DataStore db;
		CustomMap customMap;

		public MapViewModel ()
		{
			db = new DataStore ();
			//var x = ExecuteLoadMapAsync ();
		}

		//		public ObservableRangeCollection<Location> Locations { get; } = new ObservableRangeCollection<Location>();
		//
		//		#region Commands
		//		ICommand  forceRefreshCommand;
		//		public ICommand ForceRefreshCommand =>
		//		forceRefreshCommand ?? (forceRefreshCommand = new Command(async () => await ExecuteForceRefreshCommandAsync()));
		//
		//		async Task ExecuteForceRefreshCommandAsync()
		//		{
		//			await ExecuteLoadMapAsync(true);
		//		}
		//		async Task<bool> ExecuteLoadMapAsync (bool force = false)
		//		{
		//
		//			//Filter = string.Empty;
		//			#if DEBUG
		//			await Task.Delay (1000);
		//			#endif
		//
		//			var test = await db.GetItemsAsync ();
		//			var list = test.ToList ();
		//
		//			Locations.ReplaceRange (list);
		//			var map = new Map (MapSpan.FromCenterAndRadius (new Position (37, -122), Distance.FromMiles (10)));
		//			customMap.CustomPins = new List<CustomPin> { };
		//			foreach (Location lc in Locations) {
		//
		//				var pin = new CustomPin {
		//					Pin = new Pin {
		//						Type = PinType.Place,
		//						Position = new Position (lc.Longitude, lc.Latitude),
		//						Label = "Label",
		//						Address = lc.Address
		//					},
		//					Id = "Xamarin",
		//					Url = "http://xamarin.com/about/"
		//				};
		//				customMap.CustomPins. = pin;
		//				customMap.Pins.Add (pin.Pin);
		//			}
		//
		//
		//
		//			customMap.MoveToRegion (MapSpan.FromCenterAndRadius (new Position (-27.476669, 153.027948), Distance.FromMiles (1.0)));
		//
		//
		//
		//
		//
		//
		//			return true;
		//		}

		//#endregion
		//}
	}
}
