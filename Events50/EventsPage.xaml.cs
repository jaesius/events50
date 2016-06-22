using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Events50
{
	public partial class EventsPage : ContentPage
	{
		public EventsPage()
		{
			InitializeComponent();

			ObservableCollection<Event> eventList = new ObservableCollection<Event>();
			EventsView.ItemsSource = eventList;
			EventsView.IsPullToRefreshEnabled = true;

			eventList.Add(new Event { name = "CS50 Intro", date = new DateTime(2016, 6, 10, 6, 30, 0), speaker="Dylan Waffle", details="This is CS50xMiami" });
			eventList.Add(new Event { name = "CS50 Coding Hours", date = new DateTime(2016, 6, 13, 6, 30, 0), speaker = "Cecil Phillips", details = "Bet you hate Mario by now." });

			EventsView.ItemSelected += async (sender, e) =>  {

				if (e.SelectedItem == null)
				{
					return;
				}
				else {
					Event selected = e.SelectedItem as Event;
					((ListView)sender).SelectedItem = null;
					await Navigation.PushAsync(new EventDetailPage(selected));
				}

			};
		}

	}
}

