using System;
using Xamarin.Forms;

namespace SmartParking2
{
	public class NonScrollableListView : ListView
	{
		public NonScrollableListView ()
			: base (ListViewCachingStrategy.RecycleElement)
		{
			
		}
	}
}

