using System;
using MvvmHelpers;
using System.Windows.Input;
using System.Threading.Tasks;
using Plugin.ExternalMaps;
using Xamarin.Forms;
using System.Net;

namespace SmartParking2
{
	public class LocationDetailsViewModel :BaseViewModel
	{
		public Location Location { get; set; }



		ICommand _mapNavigate;

		public ICommand NavigateCommand {
			get {
				return _mapNavigate ?? (_mapNavigate = new Command (async () => await ExecuteNavigateCommandAsync ()));
			}
		}

		public LocationDetailsViewModel (Location location)
		{
			Location = location;
		}

		public void Full ()
		{
			Location.IsFull = true;
		}

		async Task ExecuteNavigateCommandAsync ()
		{
			
			switch (Device.OS) {
			case TargetPlatform.iOS:
				Device.OpenUri (
					new Uri (string.Format ("http://maps.apple.com/?q={0}", WebUtility.UrlEncode (Location.Address))));
				break;
			case TargetPlatform.Android:
				Device.OpenUri (
					new Uri (string.Format ("geo:0,0?q={0}", WebUtility.UrlEncode (Location.Address))));
				break;
			case TargetPlatform.Windows:
			case TargetPlatform.WinPhone:
				Device.OpenUri (
					new Uri (string.Format ("bingmaps:?where={0}", Uri.EscapeDataString (Location.Address))));
				break;
			}

		}
	}
}

