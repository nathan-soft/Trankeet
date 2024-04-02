namespace Trankeet_API.Models
{
    public class AdminActionLog
    {
        public int LogID { get; set; }
        public int AdminID { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }


        //public User Admin { get; set; }
    }
}
