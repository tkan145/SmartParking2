using System;
using Microsoft.Practices.ServiceLocation;
using System.Diagnostics.CodeAnalysis;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace SmartParking2
{
	public class Locator
	{
		public const string LocationPageKey = "Test";
		public const string LocationDetailPageKey = "LocationViewDetailPage";




		static Locator ()
		{
			ServiceLocator.SetLocatorProvider (() => SimpleIoc.Default);

			SimpleIoc.Default.Register<INavigationService> ();
			SimpleIoc.Default.Register<LocationViewModel> ();
			SimpleIoc.Default.Register<LocationDetailsViewModel> ();
		}

		[SuppressMessage ("Microsoft.Performance",
			"CA1822:MarkMembersAsStatic",
			Justification = "This non-static member is needed for data binding purposes.")]
		public LocationViewModel Main {
			get {
				return ServiceLocator.Current.GetInstance<LocationViewModel> ();
			}
		}

		public LocationDetailsViewModel Detail {
			get {
				return ServiceLocator.Current.GetInstance<LocationDetailsViewModel> ();
			}
		}
	}
}

