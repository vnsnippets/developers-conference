namespace Calcium.Core.Models;

public static class Widgets
{
    public class Countdown
    {
        public DateTime Deadline { get; set; } = DateTime.Now;
        public string Heading { get; set; } = string.Empty;
    }

    public class Waitlist {
        public string? Title { get; set; }
        public string[] Captions { get; set; } = [];
        public string? Icon { get; set; }
        public string? Placeholder { get; set; }
        public string? CTA { get; set; }
    }
}
