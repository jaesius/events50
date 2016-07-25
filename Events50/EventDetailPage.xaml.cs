using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Events50
{
	public partial class EventDetailPage : ContentPage
	{
		public EventDetailPage(Event selected)
		{
			InitializeComponent();
			BindingContext = selected;

			var position = new Position(25.777620, -80.190909); // Latitude, Longitude
			var pin = new Pin
			{
				Type = PinType.Place,
				Position = position,
				Label = "The Idea Center @ Miami Dade College",
				Address = "300 NE 2nd Ave, Miami, FL 33132"
			};
			//pin.Clicked += async (sender, e) =>
			//{
			//	await DisplayAlert("This is a tag", "Click click, click", "Cancel");
			//};
			EventMap.Pins.Add(pin);

			EventMap.MoveToRegion(
				MapSpan.FromCenterAndRadius(
					new Position(25.777620, -80.190909), Distance.FromMiles(.3)));
		}
	}
}

