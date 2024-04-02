namespace Trankeet_API.Models
{
    public class UserAnalytics
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
        public string AdditionalData { get; set; }

        //public User User { get; set; }
    }
}
