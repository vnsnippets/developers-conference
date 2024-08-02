using static Calcium.Core.Types.Lists;

namespace Calcium.Core.Types;

public static class Layouts
{
    public class SectionWithTitleParameters
    {
        public string Title { get; set; } = string.Empty;
        public string Caption { get; set; } = string.Empty;
    }
}

public static class Sections
{
    public class Hero
    {
        public string Title { get; set; } = string.Empty;
        public string[] Subtitles { get; set; } = [];
        public Link? CTA { get; set; }
    }

    public class Cards : Layouts.SectionWithTitleParameters
    {
        public List<Card> Items { get; set; } = [];
    }

    public class Gallery : Layouts.SectionWithTitleParameters
    {
        public List<string> Images { get; set; } = [];
    }
}
