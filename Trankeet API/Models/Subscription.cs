namespace Trankeet_API.Models
{
    public class Subscription
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int PlanID { get; set; }
        public string PaymentStatus { get; set; }

        //public User User { get; set; }
    }
}
