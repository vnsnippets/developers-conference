using Calcium.Core.Schema;
using Calcium.Core.Schema.Layouts;
using Calcium.Core.Schema.Sections;
using Calcium.Core.Schema.Widgets;

namespace Calcium.Core;

public static class Site
{
    public readonly static string Title = "Developers Conference 2025";
    public readonly static string ResourcesBaseURL = "https://raw.githubusercontent.com/vnsnippets/developers-conference/release/resources/.resources";
    
    public readonly struct Brand
    {
        public readonly static string Label = "Developers Conference";
        public readonly static string ImagePath = "images/brand.svg";
        public readonly static string URL = "/";
    }

    public readonly struct Menus
    {
        public readonly static List<Schema.Elements.Social> Social = [
            new("facebook", "https://facebook.com", Channel.Facebook),
            new("instagram", "https://instagram.com", Channel.Instagram),
            new("linkedin", "https://linkedin.com", Channel.LinkedIn)
        ];
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

        public readonly static ContentWithTitle<List<Content>> Subscriptions = new()
        {
            Title = "Want to be a part of it?",
            Caption = "Our conference is a community event, built and organised by the community for the community. You can help make it happen as a sponsor or a speaker.",
            Content = [
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
                    Title = "Submit a session",
                    Caption = "We are excited to see what kind of talks will come up this year! If you are interested in joining the conference as a speaker, submit your session proposal through our call for proposals.",
                    Link = "#",
                    Index = 1
                }
            ]
        };

        public readonly static ContentWithTitle<List<Content>> Metrics = new()
        {
            Title = "Let's have a blast!",
            Caption = "Our community and team absolutely loved the energy in the last conference. We are looking forward to your participation in the next one!",
            Content = [
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

    public readonly struct Widgets
    {
        public readonly static Countdown Countdown = new()
        {
            Deadline = new DateTime(2025, 07, 25, 08, 00, 00),
            Heading = "Count #{Every Second}# Until The Event",
            Event = new Calendar()
            {
                Title = "Developers Conference 2025",
                Description = "Join the Developers Conference 2025 along with developers,enthusiasts and industry experts for an engaging three days of technology! The theme of the day is: Emojis!",
                Location = "Caudan Arts Centre, Port Louis",
                Start = new DateOnly(2025, 7, 24),
                End = new DateOnly(2025, 7, 26),
                Label = "Add To Calendar"
            }
        };

        public readonly static Waitlist Waitlist = new() {
            Title = "Join our waitlist",
            Captions = [
                "Be the first to know when registration for the conference opens next year.",
                "An invitation will be delivered straight to your inbox 😉"
            ],
            Icon = "Smilies/Smiling Face with Heart-Eyes.png",
            Placeholder = "Enter your email address",
            CTA = "Join Waitlist"
        };

        public readonly static ContentWithTitle<List<Testimonial>> Testimonials = new()
        {
            Title = "Did you hear?",
            Caption = "Our attendees and speakers had some great things to share about the event.",
            Content = [
                new() {
                    Quote = "Reviews are often paired with carousels for interactivity and efficiency. The slide currently under focus is distinguished by a different colour scheme and a higher opacity.",
                    Author = "Jane Doe 1",
                    Credentials = "CEO",
                    Source = "https://linkedin.com",
                    Image = "https://avatars.githubusercontent.com/u/16542151?v=4",
                    Icon = "Smilies/Nerd Face.png"
                },
                new() {
                    Quote = "Reviews are often paired with carousels for interactivity and efficiency. The slide currently under focus is distinguished by a different colour scheme and a higher opacity.",
                    Author = "John Smith 2",
                    Credentials = "CEO",
                    Source = "https://linkedin.com",
                    Image = "https://avatars.githubusercontent.com/u/16542151?v=4",
                    Icon = "Smilies/Nerd Face.png"
                },
                new() {
                    Quote = "Reviews are often paired with carousels for interactivity and efficiency. The slide currently under focus is distinguished by a different colour scheme and a higher opacity.",
                    Author = "Jane Doe 3",
                    Credentials = "CEO",
                    Source = "https://linkedin.com"
                },
                new() {
                    Quote = "Reviews are often paired with carousels for interactivity and efficiency. The slide currently under focus is distinguished by a different colour scheme and a higher opacity.",
                    Author = "John Smith 4",
                    Credentials = "CEO",
                    Source = "https://linkedin.com",
                    Image = "https://avatars.githubusercontent.com/u/16542151?v=4",
                    Icon = "Smilies/Nerd Face.png"
                },
                new() {
                    Quote = "Reviews are often paired with carousels for interactivity and efficiency. The slide currently under focus is distinguished by a different colour scheme and a higher opacity.",
                    Author = "Jane Doe 5",
                    Credentials = "CEO",
                    Source = "https://linkedin.com"
                },
                new() {
                    Quote = "Reviews are often paired with carousels for interactivity and efficiency. The slide currently under focus is distinguished by a different colour scheme and a higher opacity.",
                    Author = "John Smith 6",
                    Credentials = "CEO",
                    Source = "https://linkedin.com",
                    Image = "https://avatars.githubusercontent.com/u/16542151?v=4",
                    Icon = "Smilies/Nerd Face.png"
                },
                new() {
                    Quote = "Reviews are often paired with carousels for interactivity and efficiency. The slide currently under focus is distinguished by a different colour scheme and a higher opacity.",
                    Author = "Jane Doe 7",
                    Credentials = "CEO",
                    Source = "https://linkedin.com"
                }
            ]
        };

        public readonly static ContentWithTitle<List<Feature>> Features = new()
        {
            Title = "What to expect?",
            Caption = "Learn about industry trends, best practices and new innovations through sessions and workshops when you are not having fun with all the entertainment and activities.",
            Content = [
                new() {
                    Title = "Workshops",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Activities/Artist Palette.png"
                },
                new() {
                    Title = "Panel Discussions",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Activities/Bullseye.png"
                },
                new() {
                    Title = "Speaker Sessions",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Activities/Performing Arts.png"
                },
                new() {
                    Title = "Friendly Atmosphere",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Activities/Bowling.png"
                },
                new() {
                    Title = "Activities",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Activities/Sports Medal.png"
                },
                new() {
                    Title = "Networking",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Icon = "Objects/Necktie.png"
                }
            ]
        };
    }

    public readonly struct Footer
    {
        public readonly static string Message = "MSCC DEVELOPERS CONFERENCE 2025";
    }
}