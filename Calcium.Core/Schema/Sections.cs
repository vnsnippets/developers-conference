namespace Calcium.Core.Schema
{

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
            public string[] Title { get; set; } = [];
            public string[] Captions { get; set; } = [];
            public Lists.Link[] CTA { get; set; } = [];
        }

        public class Content
        {
            public int Index { get; set; }
            public string? Icon { get; set; }
            public bool Featured { get; set; } = false;
            public string Title { get; set; } = string.Empty;
            public string Caption { get; set; } = string.Empty;
            public string? Link { get; set; }
        }
    }
}