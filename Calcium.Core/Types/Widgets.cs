namespace Calcium.Core.Types;

public static class Widgets
{
    public class Countdown
    {
        public DateTime Deadline { get; set; } = DateTime.Now;
        public string Heading { get; set; } = string.Empty;
    }
}
