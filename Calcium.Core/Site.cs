﻿namespace Calcium.Core;

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
        public readonly static List<Types.Lists.Social> Social = [
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
            CTA = new("LEARN MORE", "#section-cta")
        };

        public readonly static Types.Sections.Cards Subscriptions = new()
        {
            Title = "Join us in 2025!",
            Caption = "We would love to have you onboard as a sponsor or speaker.",
            Items = [
                new() {
                    Featured = true,
                    Title = "Embark on the journey with us!",
                    Caption = "Sponsor our community event and help us create lasting impact in the industry on the island.",
                    CTA = new("BECOME A SPONSOR", "#"),
                    Index = 0
                },
                new() {
                    Title = "The floor is yours!",
                    Caption = "Submit a session proposal for our conference and inspire others. Don't miss out!",
                    CTA = new("SUBMIT SESSION", "#"),
                    Index = 1
                }
            ]
        };

        public readonly static Types.Sections.Cards Metrics = new()
        {
            Title = "Throwback to 2024",
            Caption = "Go back in time and re-live last year's conference through pictures.",
            Items = [
                new() {
                    Index = 0,
                    Featured = true,
                    Title = "1600+",
                    Caption = "Attendees",
                    Icon = "🥳"
                },
                new() {
                    Index = 1,
                    Title = "80+",
                    Caption = "Speakers",
                    Icon = "👩‍💻"
                },
                new() {
                    Index = 2,
                    Title = "70+",
                    Caption = "Sessions",
                    Icon = "🚀"
                },
                new() {
                    Index = 3,
                    Title = "20+",
                    Caption = "Sponsors",
                    Icon = "🥰"
                }
            ]
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