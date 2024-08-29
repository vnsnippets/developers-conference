using Calcium.Toolkit.Oxide.Widgets.Schema;
using Calcium.Toolkit.Schema.Layouts;
using Calcium.Toolkit.Schema.Sections;

namespace Calcium.Web
{
    public class Site
    {
        public readonly static string Title = "Developers Conference 2025";
        public readonly static string ResourcesBaseURL = "https://raw.githubusercontent.com/vnsnippets/developers-conference/release/resources/.resources";

        public readonly struct Brand
        {
            public readonly static string Label = "Developers Conference";
            public readonly static string ImagePath = "images/brand.svg";
            public readonly static string URL = "/";
        }

        public readonly struct Footer
        {
            public readonly static string Message = "MSCC DEVELOPERS CONFERENCE 2025";
        }

        public readonly struct Sections
        {
            public readonly static Hero Hero = new()
            {
                Title = [
                    "Devel#{Smilies/Face with Open Mouth | O}#pers",
                    "C#{Smilies/Nerd Face | O}#nference",
                    "2025"
                ],
                Captions = [
                    "24 - 26 July 2025",
                    "Caudan Art Centre"
                ],
                CTA = [
                    new("❤️ Contribute As Sponsor", "mailto:vidush.namah@orion-next.com", "primary"),
                    new("Join As Speaker", "#section-cta")
                ]
            };


            public readonly static ContentWithTitle<List<ContentWithIcon>> Subscriptions = new()
            {
                Title = "Want to be a part of it?",
                Caption = "Our conference is a community event, built and organised by the community for the community. You can help make it happen as a sponsor or a speaker.",
                Content = [
                    new() {
                    Icon = "Smilies/Star-Struck.png",
                    Highlight = true,
                    Title = "Sponsor the event!",
                    Caption = "Our conference has always been free of charge - and that's only possible with your support. Become a sponsor and grab your front-row seat as you help us organize the next one.",
                    Link = "mailto:vidush.namah@orion-next.com",
                    Index = 0
                },
                new() {
                    Icon = "Smilies/Grinning Face with Big Eyes.png",
                    Title = "Submit a session",
                    Caption = "We are excited to see what kind of talks will come up this year! If you are interested in joining the conference as a speaker, submit your session proposal through our call for proposals.",
                    Link = "#",
                    Index = 1
                }
                ]
            };

            public readonly static ContentWithTitle<List<ContentWithIcon>> Metrics = new()
            {
                Title = "Let's have a blast!",
                Caption = "Our community and team absolutely loved the energy in the last conference. We are looking forward to your participation in the next one!",
                Content = [
                    new() {
                    Index = 0,
                    Highlight = true,
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

            public readonly static ContentWithTitle<List<ContentWithIcon>> Features = new()
            {
                Title = "What to expect?",
                Caption = "Learn about industry trends, best practices and new innovations through sessions and workshops when you are not having fun with all the entertainment and activities.",
                Content = [
                    new() {
                    Title = "Workshops",
                    Caption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Activities/Artist Palette.png"
                },
                new() {
                    Title = "Panel Discussions",
                    Caption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Activities/Bullseye.png"
                },
                new() {
                    Title = "Speaker Sessions",
                    Caption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Activities/Performing Arts.png"
                },
                new() {
                    Title = "Friendly Atmosphere",
                    Caption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Activities/Bowling.png"
                },
                new() {
                    Title = "Activities",
                    Caption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Activities/Sports Medal.png"
                },
                new() {
                    Title = "Networking",
                    Caption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Objects/Necktie.png"
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

        public readonly struct Widgets
        {
            public readonly static Countdown Countdown = new()
            {
                Deadline = new DateTime(2025, 07, 25, 08, 00, 00),
                Heading = "Count #{Every Second}# Until The Event",
            };

            public readonly static Calendar Calendar = new()
            {
                Heading = "Save the date in your calendar!",
                Title = "Developers Conference 2025",
                Description = "Join the Developers Conference 2025 along with developers,enthusiasts and industry experts for an engaging three days of technology! The theme of the day is: Emojis!",
                Location = "Caudan Arts Centre, Port Louis",
                Start = new DateTimeOffset(2025, 7, 24, 08, 00, 00, TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow)),
                End = new DateTimeOffset(2025, 7, 26, 17, 00, 00, TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow)),
                AllDayEvent = true,
                Label = "Download Calendar File"
            };

            public readonly static Waitlist Waitlist = new()
            {
                Title = "Join our waitlist",
                Captions = [
                    "Be the first to know when registration for the conference opens next year.",
                "An invitation will be delivered straight to your inbox 😉"
                ],
                Icon = "Smilies/Smiling Face with Heart-Eyes.png",
                Placeholder = "Enter your email address",
                CTA = "Join Waitlist"
            };
        }
    }
}
