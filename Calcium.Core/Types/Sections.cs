namespace Calcium.Core.Types;

public static class Sections
{
    public class Hero
    {
        public string Title { get; set; } = string.Empty;
        public string[] Subtitles { get; set; } = [];
        public Links.Navigation? CTA { get; set; }
    }
}
