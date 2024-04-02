namespace Trankeet_API.Models
{
    public class SubscriptionPlan
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
