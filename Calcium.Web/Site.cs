using Calcium.Toolkit.Oxide.Widgets.Schema;
using Calcium.Toolkit.Schema;
using Calcium.Toolkit.Schema.Layouts;
using Calcium.Toolkit.Schema.Sections;
using Calcium.Web.Assets;
using System.Threading.Channels;

namespace Calcium.Web
{
    public class Site
    {

        public readonly static string Title = "Developers Conference 2025";
        //public readonly static string ResourcesBaseURL = "https://raw.githubusercontent.com/vnsnippets/developers-conference/release/resources/.resources";
        public readonly static string ResourcesBaseURL = "https://raw.githubusercontent.com/vnsnippets/developers-conference/release/resources/.optimized";
        public static string EmojiPath(string path) => $"{ResourcesBaseURL}/{path}";

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

        public readonly struct Menus
        {

            public readonly static List<BaseLink> Socials = [
                new("facebook", "https://facebook.com") {
                    IconFragment = Social.Facebook
                },
                new("instagram", "https://instagram.com") {
                    IconFragment = Social.Instagram
                },
                new("linkedin", "https://linkedin.com") {
                    IconFragment = Social.LinkedIn
                }
            ];
        }

        public readonly struct Sections
        {
            public readonly static Hero Hero = new()
            {
                Title = "Devel#{Smilies/Face with Open Mouth | O}#pers C#{Smilies/Nerd Face | O}#nference 2025",
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
                    new("Sponsor the event!", "Our conference has always been free of charge - and that's only possible with your support. Become a sponsor and grab your front-row seat as you help us organize the next one.") {
                        Icon = EmojiPath("Smilies/Star-Struck.png"),
                        Highlight = true,
                        Link = "mailto:vidush.namah@orion-next.com",
                        Index = 0
                    },
                    new("Submit a session", "We are excited to see what kind of talks will come up this year! If you are interested in joining the conference as a speaker, submit your session proposal through our call for proposals.") {
                        Icon = EmojiPath("Smilies/Grinning Face with Big Eyes.png"),
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
                    new("1600+", "Attendees") {
                        Index = 0,
                        Highlight = true,
                        Icon = EmojiPath("Smilies/Partying Face.png")
                    },
                    new("80+", "Speakers") {
                        Index = 1,
                        Icon = EmojiPath("People with professions/Technologist Medium Skin Tone.png")
                    },
                    new("70+", "Sessions") {
                        Index = 2,
                        Icon = EmojiPath("Travel and places/Rocket.png")
                    },
                    new("20+", "Sponsors") {
                        Index = 3,
                        Icon = EmojiPath("Smilies/Smiling Face with Hearts.png")
                    }
                ]
            };

            public readonly static ContentWithTitle<List<ContentWithIcon>> Features = new()
            {
                Title = "What to expect?",
                Caption = "Learn about industry trends, best practices and new innovations through sessions and workshops when you are not having fun with all the entertainment and activities.",
                Content = [
                    new("Workshops", "Led by industry experts, these workshops offer a unique opportunity to gain practical skills and insights, making them a valuable experience for both beginners and seasoned professionals.") {
                        Icon = EmojiPath("Activities/Artist Palette.png")
                    },
                    new("Panel Discussions", "The panel discussions bring together thought leaders and innovators to explore current trends, challenges, and the future of technology. These engaging sessions provide a platform for diverse perspectives and lively debates, sparking new ideas and inspiring our community.") {
                        Icon = EmojiPath("Activities/Bullseye.png")
                    },
                    new("Speaker Sessions", "DevCon sessions are packed with knowledge-sharing and inspiration, featuring local and international speakers. From cutting-edge innovations to practical applications, these talks cover a wide range of topics, ensuring there's something for everyone, whether you're a developer, designer, or entrepreneur.") {
                        Icon = EmojiPath("Activities/Performing Arts.png")
                    },
                    new("Friendly Atmosphere", "DevCon is known for its warm and inclusive atmosphere. Whether you are a first-time attendee or a conference veteran, you'll feel right at home. Our community is supportive and eager to connect, making DevCon a place where lasting professional relationships are formed.") {
                        Icon = EmojiPath("Activities/Bowling.png")
                    },
                    new("Activities", "Beyond the sessions and discussions, DevCon offers a range of cool activities that add an extra layer of fun to the conference. From interactive games to creative challenges, these activities are designed to engage and entertain, making DevCon a memorable experience for all attendees.") {
                        Icon = EmojiPath("Activities/Sports Medal.png")
                    },
                    new("Networking", "The networking hour is an 'invitation-only' event, offering a relaxed environment to connect with peers, mentors, and industry leaders. It's the perfect opportunity to exchange ideas, collaborate on projects, and expand your professional network in a casual, friendly setting.") {
                        Icon = EmojiPath("Objects/Necktie.png")
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
                Icon = EmojiPath("Smilies/Smiling Face with Heart-Eyes.png"),
                Placeholder = "Enter your email address",
                CTA = "Join Waitlist"
            };
        }
    }
}
