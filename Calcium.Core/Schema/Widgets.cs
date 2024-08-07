using System.Text;

namespace Calcium.Core.Schema.Widgets
{
    public class Calendar
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateOnly Start { get; set; }
        public DateOnly End { get; set; }
        public string Label { get; set; } = "Add to Calendar";

        public byte[] AsICSCalendarEvent()
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
    }

    public class Countdown
    {
        public DateTime Deadline { get; set; } = DateTime.Now;
        public string Heading { get; set; } = string.Empty;
        public Calendar? Event { get; set; }
    }

    public class Waitlist {
        public string? Title { get; set; }
        public string[] Captions { get; set; } = [];
        public string? Icon { get; set; }
        public string? Placeholder { get; set; }
        public string? CTA { get; set; }
    }
}
