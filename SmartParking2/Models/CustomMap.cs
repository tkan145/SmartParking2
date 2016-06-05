using System.Collections.Generic;
using Xamarin.Forms.Maps;

namespace SmartParking2
{
	public class CustomMap:Map
	{
		public List<CustomPin> CustomPins{ get; set; }
	}
}

