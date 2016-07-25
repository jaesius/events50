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

			eventList.Add(new Event { name = "CS50x Preview", date = new DateTime(2016, 6, 10, 6, 30, 0), speaker = "Lecturer: Dylan Waffle", details = "This is CS50xMiami" });
			eventList.Add(new Event { name = "CS50x Coding Hours", date = new DateTime(2016, 6, 13, 6, 30, 0), speaker = "Section Leader: Cecil Phillips", details = "Bet you hate Mario by now." });
			eventList.Add(new Event { name = "CS50x Puzzle Day", date = new DateTime(2016, 6, 18, 6, 30, 0), details = "CS50xMiami Cohort 5 Meet and Greet!" });
			eventList.Add(new Event { name = "Big Data", date = new DateTime(2016, 6, 20, 6, 30, 0), speaker = "Lecturer: TF Chang", details = "Idea Center course on data analytics." });
			eventList.Add(new Event { name = "Speaker Series: Next-Gen Leaders", date = new DateTime(2016, 6, 22, 6, 30, 0), speaker = "Lecturer: Sari NotSorry", details = "Meet the leaders who are transforming Miami tech!" });
			eventList.Add(new Event { name = "Speaker Series: Code for Good", date = new DateTime(2016, 6, 23, 6, 30, 0), speaker = "Lecturer: Dylan Waffle", details = "Local entrepreneur will share how he's using tech to transform city governement!" });
			eventList.Add(new Event { name = "IDC Hackathon", date = new DateTime(2016, 6, 25, 6, 30, 0), speaker = "Lecturer: Panel", details = "Come create apps to improve efficiency in the Idea Center!" });
			eventList.Add(new Event { name = "CS50x Project Day", date = new DateTime(2016, 6, 27, 6, 30, 0), details = "CS50xMiami Cohort 5 final project presentation." });
			eventList.Add(new Event { name = "Speaker Series: Google Analytics", date = new DateTime(2016, 6, 29, 6, 30, 0), speaker = "Lecturer: TF Chang", details = "Idea Center course on Google analytics." });
			eventList.Add(new Event { name = "Speaker Series: Launchcode", date = new DateTime(2016, 7, 1, 6, 30, 0), speaker = "Lecturer: Sari NotSorry", details = "Meet the team that can help you start a career in tech!" });

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

