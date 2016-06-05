using System;
using System.Threading.Tasks;
using System.Reflection;
using Newtonsoft.Json;
using PCLStorage;
using Plugin.EmbeddedResource;
using System.Collections;
using System.Collections.Generic;
using MvvmHelpers;

namespace SmartParking2
{
	public class DataStore
	{
		

		public DataStore ()
		{
			
		}

		private const string jsonFile = "locations.json";
		private const string assmName = "SmartParking2";

		public async Task<IEnumerable<Location>> GetItemsAsync ()
		{
			var rootFolder = FileSystem.Current.LocalStorage;
			var json = ResourceLoader.GetEmbeddedResourceString (Assembly.Load (new AssemblyName (assmName)), jsonFile);
			return await Task.Run (() => JsonConvert.DeserializeObject<List<Location>> (json));
			//return null;
		}
	}
}

