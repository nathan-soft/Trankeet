namespace Trankeet_API.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int UserID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionID { get; set; }
        public User User { get; set; }
    }
}
