namespace Calcium.Core.Models
{
    public static class Lists
    {
        public class Link(string name, string url, string? type = null)
        {
            public string Id { get; set; } = Guid.NewGuid().ToString();
            public int Index { get; set; } = 0;
            public string Name { get; set; } = name;
            public string URL { get; set; } = url ?? string.Empty;
            public string? Type { get; set; } = type;
        }

        public class Social(string name, string url, Icon icon) : Link(name, url)
        {
            public Icon Icon { get; set; } = icon;
        }

        public class Card
        {
            public int Index { get; set; }
            //public Icon Icon { get; set; }
            public string? Icon { get; set; }
            public bool Featured { get; set; } = false;
            public string Title { get; set; } = string.Empty;
            public string Caption { get; set; } = string.Empty;
            public string Conditions { get; set; } = string.Empty;
            public string? Link { get; set; }
        }
    }
}
