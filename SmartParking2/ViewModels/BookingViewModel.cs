using System;
using MvvmHelpers;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;


namespace SmartParking2
{
	public class BookingViewModel:BaseViewModel
	{
		public Location Location { get; set; }

		public BookingViewModel (Location location)
		{
			Location = location;
		}
	}
}

