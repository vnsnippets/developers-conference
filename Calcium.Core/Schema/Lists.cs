namespace Calcium.Core.Schema
{
    public enum Channel { None, Facebook, Instagram, Github, LinkedIn, X }

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

        public class Social(string name, string url, Channel icon) : Link(name, url)
        {
            public Channel Icon { get; set; } = icon;
        }
    }
}
