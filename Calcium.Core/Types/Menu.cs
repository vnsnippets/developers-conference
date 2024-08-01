namespace Calcium.Core.Types
{
    public enum Channel { Facebook, Instagram, Github, LinkedIn, X }

    public static class Links
    {
        public class Navigation(string name, string url)
        {
            public string Id { get; set; } = Guid.NewGuid().ToString();
            public int Index { get; set; } = 0;
            public string Name { get; set; } = name;
            public string URL { get; set; } = url ?? string.Empty;
        }

        public class Social(string name, string url, Channel type) : Navigation(name, url)
        {
            public Channel Type { get; set; } = type;
        }
    }
}
