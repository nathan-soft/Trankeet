namespace Trankeet_API.Models
{
    public class ChatMsg
    {
        public int MessageID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public bool ReadStatus { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
}
