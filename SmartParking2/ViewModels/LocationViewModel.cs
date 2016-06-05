using System;
using MvvmHelpers;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight;

namespace SmartParking2
{
	public class LocationViewModel : BaseViewModel
	{
		DataStore db;
		private readonly INavigationService _navigationService;

		public LocationViewModel ()
		{
			db = new DataStore ();

			//_navigationService = navigationService;
			NavigationCommand =
				new Command(() =>  _navigationService.NavigateTo(Locator.LocationPageKey));

			var x = ExecuteLoadLocationsAsync ();
		}

		public ICommand NavigationCommand{ get; set;}

		public ObservableRangeCollection<Location> Locations { get; } = new ObservableRangeCollection<Location>();

		bool _noLocationsFound;

		public bool NoLocationsFound {
			get { return _noLocationsFound; }
			set { SetProperty (ref _noLocationsFound, value); }
		}

		string _noLocationsFoundMessage;

		public string NoLocationsFoundMessage {
			get { return _noLocationsFoundMessage; }
			set { SetProperty (ref _noLocationsFoundMessage, value); }
		}

		#region Commands

		ICommand  forceRefreshCommand;
		public ICommand ForceRefreshCommand =>
		forceRefreshCommand ?? (forceRefreshCommand = new Command(async () => await ExecuteForceRefreshCommandAsync())); 

		async Task ExecuteForceRefreshCommandAsync()
		{
			await ExecuteLoadLocationsAsync(true);
		}

		async Task<bool> ExecuteLoadLocationsAsync (bool force = false)
		{
			if (IsBusy)
				return false;
			try {
				//NextForceRefresh = DateTime.UtcNow.AddMinutes(45);
				IsBusy = true;
				NoLocationsFound = false;

				//Filter = string.Empty;
				#if DEBUG
				await Task.Delay (1000);
				#endif

				var test = await db.GetItemsAsync ();
				var list = test.ToList();

				Locations.ReplaceRange (list);
				if (NoLocationsFound = Locations.Count == 0)
					NoLocationsFoundMessage = "No Locations Found";

			} catch (Exception ex) {
				Debug.WriteLine (ex);
			} finally {
				IsBusy = false;
			}
			return true;
		}
		#endregion
	}
}

