using Microsoft.AspNetCore.Components;
using System.Xml.Linq;

namespace Calcium.Toolkit.Schema
{
    public enum SocialMediaTypes
    {
        None,
        Facebook,
        Instagram,
        Github,
        LinkedIn,
        X
    }
    public struct Brand
    {
        public string BaseURL { get; set; }
        public string Label { get; set; }
        public string ImagePath { get; set; }
    };

    public class BaseLink(string name, string url, string? type = null)
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int Index { get; set; } = 0;
        public string Name { get; set; } = name;
        public string URL { get; set; } = url ?? string.Empty;
        public string? Type { get; set; } = type;
        public RenderFragment? IconFragment { get; set; }
    }

    public class SocialLink(string name, string url, SocialMediaTypes icon) : BaseLink(name, url)
    {
        public SocialMediaTypes Icon { get; set; } = icon;
    }

    public class Footer
    {
        public string? Message { get; set; }
    }

    namespace Layouts
    {
        public class ContentWithTitle<T> where T : class
        {
            public string Title { get; set; } = string.Empty;
            public string Caption { get; set; } = string.Empty;

            public T? Content { get; set; }
        }
    }

    namespace Sections
    {
        public class Hero
        {
            public string? Title { get; set; }
            public string[] Captions { get; set; } = [];
            public BaseLink[] CTA { get; set; } = [];
        }

        public class BaseContent(string title, string caption)
        {
            public int Index { get; set; }
            public string Title { get; set; } = title;
            public string Caption { get; set; } = caption;
            public string? Link { get; set; }
            public bool Highlight { get; set; } = false;
        }

        public class ContentWithIcon(string title, string caption) : BaseContent(title, caption)
        {
            public string? Icon { get; set; }
            public RenderFragment? IconFragment { get; set; }
        }
    }
}