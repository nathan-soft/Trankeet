namespace Trankeet_API.Models
{
    public class UserSettings
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string NotificationPreferences { get; set; }
        public string CommunicationPreferences { get; set; }
        public string PrivacySettings { get; set; }
        public string ThemePreferences { get; set; }


        //public User User { get; set; }
    }
}
