using System;
using MvvmHelpers;
using Xamarin.Forms;

namespace SmartParking2
{
	public interface IBaseDataObject
	{
		string Id{ get; set; }
	}

	public class BaseDataObject : ObservableObject,IBaseDataObject
	{
		public BaseDataObject ()
		{
			Id = Guid.NewGuid ().ToString ();
		}

		[Newtonsoft.Json.JsonProperty ("Id")]
		public string Id{ get; set; }
	}
}

