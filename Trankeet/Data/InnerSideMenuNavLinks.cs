namespace TrankeetWeb.Data
{
    public static class InnerSideMenuNavLinks
    {
        public static List<NavMenuItem> GetNavItems()
        {
            return new List<NavMenuItem>
            {
                new NavMenuItem("Dashboard", "/App/Dashboard"),
                new NavMenuItem("My Courses", "/App/MyCourses"),
                new NavMenuItem("Mentorships", "/App/Mentorships"),
                new NavMenuItem("Messages", "/App/Messages"),
                new NavMenuItem("Transactions", "/App/Transactions"),
                new NavMenuItem("Notifications", "/App/Notifications"),
                new NavMenuItem("Support", "/App/Support"),
                new NavMenuItem("Settings", "/App/Settings/BasicInfo")
            };
        }
    }

    public class NavMenuItem
    {
        public string Title { get; set; }
        public string UrlPath { get; set; }

        public NavMenuItem(string title, string urlPath)
        {
            Title = title;
            UrlPath = urlPath;
        }

        public string GetUrlPathWithoutLeadingSlash()
        {
            if (UrlPath == "/App/Settings/BasicInfo")
                return "App/Settings";

            return UrlPath.Substring(1);
        }
    }
}
