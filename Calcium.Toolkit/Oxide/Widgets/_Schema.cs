using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcium.Toolkit.Oxide.Widgets.Schema
{
    public class Calendar
    {
        public string Heading { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public bool AllDayEvent { get; set; } = true;
        public string? Label { get; set; }

        public byte[] CreateICSFileAsByteArray()
        {
            // Begin building string for the file
            System.Text.StringBuilder sb = new();

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
            return System.Text.Encoding.UTF8.GetBytes(sb.ToString());
        }

        public string GoogleCalendarLink
        {
            get
            {
                string dateFormat = (AllDayEvent) ? "yyyyMMdd" : "yyyyMMddTHHmmssZ";
                return $"https://calendar.google.com/calendar/render?action=TEMPLATE&dates={Start.UtcDateTime.ToString(dateFormat)}%2F{End.UtcDateTime.ToString(dateFormat)}&details={Uri.EscapeDataString(Description)}&location={Uri.EscapeDataString(Location)}&text={Uri.EscapeDataString(Title)}";
            }
        }

        public string OutlookCalendarLink
        {
            get => $"https://outlook.live.com/calendar/0/action/compose?allday={AllDayEvent.ToString().ToLowerInvariant()}&path=%2Fcalendar%2Faction%2Fcompose&rru=addevent&startdt={Uri.EscapeDataString(Start.UtcDateTime.ToString("yyyy-MM-ddTHH:mm:sszzz"))}&enddt={Uri.EscapeDataString(End.UtcDateTime.ToString("yyyy-MM-ddTHH:mm:sszzz"))}&subject={Uri.EscapeDataString(Title)}&body={Uri.EscapeDataString(Description)}&location={Uri.EscapeDataString(Location)}";
        }

        public string Office365CalendarLink
        {
            get => $"https://outlook.office.com/calendar/action/compose?allday={AllDayEvent.ToString().ToLowerInvariant()}&path=%2Fcalendar%2Faction%2Fcompose&rru=addevent&startdt={Uri.EscapeDataString(Start.UtcDateTime.ToString("yyyy-MM-ddTHH:mm:sszzz"))}&enddt={Uri.EscapeDataString(End.UtcDateTime.ToString("yyyy-MM-ddTHH:mm:sszzz"))}&subject={Uri.EscapeDataString(Title)}&body={Uri.EscapeDataString(Description)}&location={Uri.EscapeDataString(Location)}";
        }

        public string YahooCalendarLink
        {
            get
            {
                string dateFormat = (AllDayEvent) ? "yyyyMMdd" : "yyyyMMddTHHmmssZ";
                string alldaystring = ((AllDayEvent) ? "allday" : "");

                return $"https://calendar.yahoo.com/?desc={Uri.EscapeDataString(Description)}&dur={alldaystring}&in_loc={Uri.EscapeDataString(Location)}&et={End.UtcDateTime.ToString(dateFormat)}&st={Start.UtcDateTime.ToString(dateFormat)}&title={Uri.EscapeDataString(Title)}&v=60";
            }
        }
    }

    public class Countdown
    {
        public DateTime Deadline { get; set; } = DateTime.Now;
        public string Heading { get; set; } = string.Empty;
    }

    public class Waitlist
    {
        public string? Title { get; set; }
        public string[] Captions { get; set; } = [];
        public string? Icon { get; set; }
        public string? Placeholder { get; set; }
        public string? CTA { get; set; }
    }
}
