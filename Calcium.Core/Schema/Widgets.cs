using System.Text;
using System.Web;

namespace Calcium.Core.Schema.Widgets
{
    public class Calendar
    {
        public struct Labels
        {
            public string Default { get; set; }
            public string Google { get; set; }
            public string Outlook { get; set; }
            public string Office365 { get; set; }
            public string Yahoo { get; set; }
        }

        public string Heading { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public bool AllDayEvent { get; set; } = true;
        public Labels CTA { get; set; }

        public byte[] CreateICSFileAsByteArray()
        {
            // Begin building string for the file
            StringBuilder sb = new();

            // Calendar Item Metadata
            sb.AppendLine("BEGIN:VCALENDAR");
            sb.AppendLine("VERSION:2.0");
            sb.AppendLine("CALSCALE:GREGORIAN");
            sb.AppendLine("METHOD:PUBLISH");

            // Calendar Item Event
            sb.AppendLine("BEGIN:VEVENT");

            // Calendar Item Event Dates
            sb.AppendLine("DTSTART:" + Start.ToString("yyyyMMdd"));
            sb.AppendLine("DTEND:" + End.ToString("yyyyMMdd"));

            sb.AppendLine("SUMMARY:" + Title + "");
            sb.AppendLine("LOCATION:" + Location + "");
            sb.AppendLine("DESCRIPTION:" + Description + "");
            sb.AppendLine("END:VEVENT");

            // End Calendar Item
            sb.AppendLine("END:VCALENDAR");

            // Return string as bytearray
            return Encoding.UTF8.GetBytes(sb.ToString());
        }

        public string GoogleCalendarLink
        {
            get => $"https://calendar.google.com/calendar/r/render?action=TEMPLATE&dates={Start:yyyy-MM-ddThh:mm:sszzz}%2F{End:yyyy-MM-ddThh:mm:sszzz)}&details={HttpUtility.UrlEncode(Description)}&location={HttpUtility.UrlEncode(Location)}&text={HttpUtility.UrlEncode(Title)}"; //2025-07-23T20%3A00%3A00%2B00%3A00
        }

        public string OutlookCalendarLink
        {
            get => $"https://outlook.live.com/calendar/0/action/compose?allday={AllDayEvent}&path=%2Fcalendar%2Faction%2Fcompose&rru=addevent&startdt={Start:yyyy-MM-ddThh:mm:sszzz}&enddt={End:yyyy-MM-ddThh:mm:sszzz}&subject={HttpUtility.UrlEncode(Title)}&body={HttpUtility.UrlEncode(Description)}&location={HttpUtility.UrlEncode(Location)}";
        }

        public string Office365CalendarLink
        {
            get => $"https://outlook.office.com/calendar/action/compose?allday={AllDayEvent}&path=%2Fcalendar%2Faction%2Fcompose&rru=addevent&startdt={Start:yyyy-MM-ddThh:mm:sszzz}&enddt={End:yyyy-MM-ddThh:mm:sszzz}&subject={HttpUtility.UrlEncode(Title)}&body={HttpUtility.UrlEncode(Description)}&location={HttpUtility.UrlEncode(Location)}";
        }

        public string YahooCalendarLink 
        {
            get => $"https://calendar.yahoo.com/?desc={Description}&dur={((AllDayEvent) ? "allday" : "")}&in_loc={HttpUtility.UrlEncode(Location)}&et={End:yyyy-MM-ddThh:mm:sszzz}&st={Start:yyyy-MM-ddThh:mm:sszzz}&title={HttpUtility.UrlEncode(Title)}&v=60";
        }
    }

    public class Countdown
    {
        public DateTime Deadline { get; set; } = DateTime.Now;
        public string Heading { get; set; } = string.Empty;
        public Calendar? Event { get; set; }
    }

    public class Waitlist
    {
        public string? Title { get; set; }
        public string[] Captions { get; set; } = [];
        public string? Icon { get; set; }
        public string? Placeholder { get; set; }
        public string? CTA { get; set; }
    }

    public class Testimonial
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Author { get; set; }
        public string? Quote { get; set; }
        public string? Credentials { get; set; }
        public string? Source { get; set; }
        public string Icon { get; set; } = "Smilies/Nerd Face.png";
        public string? Image { get; set; }
    }

    public class Feature
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
    }
}
