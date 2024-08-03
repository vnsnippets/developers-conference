namespace Calcium.Core.Models
{
    public static class Lists
    {
        public class Link(string name, string url)
        {
            public string Id { get; set; } = Guid.NewGuid().ToString();
            public int Index { get; set; } = 0;
            public string Name { get; set; } = name;
            public string URL { get; set; } = url ?? string.Empty;
        }

        public class Social(string name, string url, Icon type) : Link(name, url)
        {
            public Icon Type { get; set; } = type;
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
            public Link? CTA { get; set; }
        }
    }
}
