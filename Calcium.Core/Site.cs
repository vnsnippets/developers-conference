using Calcium.Core.Models;

namespace Calcium.Core;

public static class Site
{
    public readonly static string Title = "Calcium Site";
    public readonly static string ResourcesBaseURL = "https://raw.githubusercontent.com/vnsnippets/developers-conference/release/resources/.optimized";
    public static class Brand
    {
        public readonly static string Label = "Developers Conference";
        public readonly static string ImagePath = "images/brand.svg";
        public readonly static string URL = "/";
    }

    public static class Menus
    {
        public readonly static List<Lists.Social> Social = [
            new("facebook", "https://facebook.com", Icon.Facebook),
            new("instagram", "https://instagram.com", Icon.Instagram),
            new("linkedin", "https://linkedin.com", Icon.LinkedIn)
        ];
    }

    public static class Sections
    {
        public readonly static Models.Sections.Hero Hero = new()
        {
            Title = [
                "Devel#{Smilies/Face with Open Mouth | O}#pers",
                "C#{Smilies/Nerd Face | O}#nference",
                "2025"
            ],
            Captions = [
                "24, 25 & 26 July 2025",
                "Caudan Art Centre"
            ],
            CTA = [
                new("Become A Sponsor", "mailto:vidush.namah@orion-next.com", "primary"),
                new("Submit Session", "#section-cta")
            ]
        };

        public readonly static Models.Sections.Cards Subscriptions = new()
        {
            Title = "Join us in 2025!",
            Caption = "We would love to have you onboard as a sponsor or speaker.",
            Items = [
                new() {
                    Icon = "Smilies/Star-Struck.png",
                    Featured = true,
                    Title = "Support the event!",
                    Caption = "Sponsor our community event and help us create lasting impact in the industry on the island.",
                    Conditions = "Contact us via email to request for sponsorship proposals.",
                    Link = "mailto:vidush.namah@orion-next.com",
                    Index = 0
                },
                new() {
                    Icon = "Smilies/Grinning Face with Big Eyes.png",
                    Title = "Become a speaker!",
                    Caption = "Submit a session proposal for our conference and become a speaker. Don't miss out!",
                    Conditions = "We look forward to have you join our line up soon.",
                    Link = "#",
                    Index = 1
                }
                // new() {
                //     Icon = "Smilies/Smiling Face with Heart-Eyes.png",
                //     Title = "Join the waitlist",
                //     Caption = "Be the first to know when our registration for the conference opens next year.",
                //     Conditions = "Our team will send you an email inviting you to register as an attendee.",
                //     Link = "#",
                //     Index = 2
                // }
            ]
        };

        public readonly static Models.Sections.Cards Metrics = new()
        {
            Title = "Throwback to 2024",
            Caption = "Go back in time and re-live last year's conference through pictures.",
            Items = [
                new() {
                    Index = 0,
                    Featured = true,
                    Title = "1600+",
                    Caption = "Attendees",
                    Icon = "Smilies/Partying Face.png"
                },
                new() {
                    Index = 1,
                    Title = "80+",
                    Caption = "Speakers",
                    Icon = "People with professions/Technologist Medium Skin Tone.png"
                },
                new() {
                    Index = 2,
                    Title = "70+",
                    Caption = "Sessions",
                    Icon = "Travel and places/Rocket.png"
                },
                new() {
                    Index = 3,
                    Title = "20+",
                    Caption = "Sponsors",
                    Icon = "Smilies/Smiling Face with Hearts.png"
                }
            ]
        };

        public readonly static string[] Gallery =
        [
            "images/Gallery-1.webp",
            "images/Gallery-2.webp",
            "images/Gallery-3.webp",
            "images/Gallery-4.webp",
            "images/Gallery-5.webp",
            "images/Gallery-6.webp",
            "images/Gallery-7.webp",
            "images/Gallery-8.webp"
        ];
    }

    public static class Widgets
    {
        public readonly static Models.Widgets.Countdown Countdown = new()
        {
            Deadline = new DateTime(2025, 07, 25, 08, 00, 00),
            Heading = "Count #{Every Second}# Until The Event"
        };

        public readonly static Models.Widgets.Waitlist Waitlist = new() {
            Title = "Join our waitlist",
            Captions = [ 
                "Be the first to know when registration for the conference opens next year.",
                "Our team will send you an email inviting you to register as an attendee."
            ],
            Icon = "Smilies/Smiling Face with Heart-Eyes.png",
            Placeholder = "Enter your email address",
            CTA = "Subscribe"
        };
    }

    public static class Footer
    {
        public readonly static string Message = "MSCC DEVELOPERS CONFERENCE 2025";
    }
}