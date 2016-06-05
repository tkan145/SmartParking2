using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SmartParking2
{
	public partial class BookingPage : ContentPage
	{
		BookingViewModel vm;

		public BookingPage (Location lo)
		{
			InitializeComponent ();
			BindingContext = vm = new BookingViewModel (lo);
		}

		async void OnButtonClicked (object sender, EventArgs args)
		{
			await Navigation.PopModalAsync ();
		}
	}
}

