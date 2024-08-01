using Calcium.Core.Types;

namespace Calcium.Core;

public static class Site
{
    public readonly static string Title = "Calcium Site";
    public static class Brand
    {
        public readonly static string Label = "Developers Conference";
        public readonly static string ImagePath = "images/brand.svg";
        public readonly static string URL = "/";
    }

    public static class Menus
    {
        public readonly static List<Types.Links.Social> Social = [
            new("facebook", "https://facebook.com", Types.Channel.Facebook),
            new("instagram", "https://instagram.com", Types.Channel.Instagram),
            new("linkedin", "https://linkedin.com", Types.Channel.LinkedIn)
        ];
    }

    public static class Sections
    {
        public readonly static Types.Sections.Hero Hero = new()
        {
            Title = "Developers Conference 2025",
            Subtitles = [
                "24, 25 & 26 July 2025",
                "Caudan Art Centre"
            ],
            CTA = new("LEARN MORE", "#join-us")
        };
    }

    public static class Widgets
    {
        public readonly static Types.Widgets.Countdown Countdown = new()
        {
            Deadline = new DateTime(2025, 07, 25, 08, 00, 00),
            Heading = "Count Every Second Until The Event"
        };
    }
}