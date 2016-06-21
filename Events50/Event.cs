using System;


namespace Events50
{
	public class Event
	{
		public string name { get; set; }
		public DateTime date { get; set; }
		public string speaker { get; set; }
		public string details { get; set; }
		public bool isPassed { get; set; }
		public int count { get; set; }
		public int totalCount { get; set; }

		public Event()
		{

		}

		public Event(string name, DateTime date, string details)
		{
			this.name = name;
			this.date = date;
			this.details = details;
			this.isPassed = false;
		}

		public Event(string name, DateTime date, string speaker, string details)
		{
			this.name = name;
			this.date = date;
			this.speaker = speaker;
			this.details = details;
			isPassed = false;
		}

		public override string ToString()
		{
			return string.Format("Name: {0}, Date: {1}, Event Information: {2}", name, date, details);
		}
	}
}

