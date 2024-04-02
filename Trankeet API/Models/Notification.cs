namespace Trankeet_API.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public int UserID { get; set; }
        public string NotificationType { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public bool ReadStatus { get; set; }


        //public User User { get; set; }
    }
}
