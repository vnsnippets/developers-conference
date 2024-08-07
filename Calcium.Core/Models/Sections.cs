using static Calcium.Core.Models.Lists;

namespace Calcium.Core.Models
{

    public static class Layouts
    {
        public class SectionWithTitleParameters
        {
            public string Title { get; set; } = string.Empty;
            public string Caption { get; set; } = string.Empty;
        }
    }

    namespace Sections
    {
        public class Hero
        {
            public string[] Title { get; set; } = [];
            public string[] Captions { get; set; } = [];
            public Link[] CTA { get; set; } = [];
        }

        public class Cards : Layouts.SectionWithTitleParameters
        {
            public List<Card> Items { get; set; } = [];
        }
    }
}