﻿using System;
using Xamarin.Forms;

namespace SmartParking2
{
	public class CardView : Frame
	{
		public CardView ()
		{
			Padding = 0;
			if (Device.OS == TargetPlatform.iOS || Device.OS == TargetPlatform.iOS) {
				HasShadow = false;
				OutlineColor = Color.Transparent;
				BackgroundColor = Color.Transparent;
			}
		}
	}
}

