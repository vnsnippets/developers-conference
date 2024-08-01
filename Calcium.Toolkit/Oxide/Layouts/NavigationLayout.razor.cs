namespace Calcium.Toolkit.Oxide.Layouts;

public partial class NavigationLayout
{
    public struct Link(string label, string url)
    {
        public string Label = label;
        public string URL = url;
    }

    public struct Brand(string imageSource, string url)
    {
        public string ImageSource = imageSource;
        public string URL = url;
    }

    public struct CTA(string label, Action method)
    {
        public string Label = label;
        public Action Method = method;
    }

    public struct NavigationElements
    {
        public IEnumerable<Link> Links;
        public Brand Brand;
    }

    private NavigationElements _elements = new NavigationElements()
    {
        Brand = new Brand("/images/brand.svg", "#"),
        Links =
            [
                new Link("PAGE-1", "#"),
                new Link("PAGE-2", "#")
            ]
    };

    public bool _IsNavigationMenuOpen { get; set; } = false;

    public string NavigationMenuClassList
    {
        get => _IsNavigationMenuOpen ? "collapse open" : "collapse";
    }

    private void ToggleNavigationMenu()
    {
        _IsNavigationMenuOpen = !_IsNavigationMenuOpen;
    }
}