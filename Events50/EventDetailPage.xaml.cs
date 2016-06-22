using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Events50
{
	public partial class EventDetailPage : ContentPage
	{
		public EventDetailPage(Event selected)
		{
			InitializeComponent();
			BindingContext = selected;
		}
	}
}

