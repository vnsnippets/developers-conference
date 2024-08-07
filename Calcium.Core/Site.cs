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
                new("❤️ Contribute As Sponsor", "mailto:vidush.namah@orion-next.com", "primary"),
                new("Join As Speaker", "#section-cta")
            ]
        };

        public readonly static Models.Sections.Cards Subscriptions = new()
        {
            Title = "Want to be a part of it?",
            Caption = "Our conference is a community event, built and organised by the community for the community. You can help make it happen as a sponsor or a speaker.",
            Items = [
                new() {
                    Icon = "Smilies/Star-Struck.png",
                    Featured = true,
                    Title = "Sponsor the event!",
                    Caption = "Our conference has always been free of charge - and that's only possible with your support. Become a sponsor and grab your front-row seat as you help us organize the next one.",
                    Link = "mailto:vidush.namah@orion-next.com",
                    Index = 0
                },
                new() {
                    Icon = "Smilies/Grinning Face with Big Eyes.png",
                    Title = "The floor is yours!",
                    Caption = "We are excited to see what kind of talks will come up this year! If you are interested in joining the conference as a speaker, submit your session proposal through our call for proposals.",
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
            Title = "Last Conference Was A Blast!",
            Caption = "Our community and team absolutely loved the energy in the last conference. We are looking forward to your participation in the next one!",
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
            Heading = "Count #{Every Second}# Until The Event",
            Event = new Models.Widgets.Calendar()
            {
                Title = "Developers Conference 2025",
                Description = "Join the Developers Conference 2025 along with developers,enthusiasts and industry experts for an engaging three days of technology! The theme of the day is: Emojis!",
                Location = "Caudan Arts Centre, Port Louis",
                Start = new DateOnly(2025,7,24),
                End = new DateOnly(2025,7,26),
                Label = "Add to Calendar"
            }
        };

        public readonly static Models.Widgets.Waitlist Waitlist = new() {
            Title = "Join our waitlist",
            Captions = [ 
                "Be the first to know when registration for the conference opens next year.",
                "An invitation will be delivered straight to your inbox 😉"
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