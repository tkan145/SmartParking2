using System;
using Newtonsoft.Json;
using SmartParking2;

namespace SmartParking2
{
	public class Location: BaseDataObject
	{
		public Location ()
		{
		}

		[JsonProperty ("id")]
		public string Id { get; set; }

		[JsonProperty ("address")]
		public string Address { get; set; }

		[JsonProperty ("city")]
		public string City { get; set; }

		[JsonProperty ("state")]
		public string state { get; set; }

		[JsonProperty ("country")]
		public string country { get; set; }

		[JsonProperty ("zipCode")]
		public string ZipCode { get; set; }

		public string Image{ get; set; }

		public string Description{ get; set; }

		public int Available{ get; set; }

		public string IsAvailable{ get; set; }

		public string Fees{ get; set; }

		public string Hour{ get; set; }

		//		public enum LotStatus
		//		{
		//FULL,
		//ALMOST,
		//FREE}
		//
		//		;
		//
		//		private string _lotCounterStatus;
		//
		//		public LotStatus LotCounterStatus {
		//			get { return _lotCounterStatus; }
		//			set{ SetProperty (ref _lotCounterStatus, value); }
		//		}

		[JsonIgnore]
		public Uri ImageUri {
			get{ return new System.Uri (Image); }
		}

		public double Latitude{ get; set; } =0;

		public double Longitude{ get; set; } =0;

		bool _isFull;

		public bool IsFull {
			get{ return _isFull; }
			set{ SetProperty (ref _isFull, value); }
		}

		public string Free{ get; set; }

		public string Suburb{ get; set; }
	}
}

