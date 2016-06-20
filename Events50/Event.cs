using System;


namespace Events50
{
	public class Event
	{
		public string name;
		public DateTime date;
		public string speaker;
		public string details;
		public bool isPassed;
		public int count;
		public int totalCount;

		public Event(name, date, details, isPassed)
		{
			this.name = name;
			this.date = date;
			this.details = details;
			this.isPassed = isPassed;

		}

		public Event(name, date, speaker, details, isPassed)
		{
			this.name = name;
			this.date = date;
			this.speaker = speaker;
			this.details = details;
			this.isPassed = isPassed;

		}
	}
}

