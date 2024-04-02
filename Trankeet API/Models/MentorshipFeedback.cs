namespace Trankeet_API.Models
{
    public class MentorshipFeedback
    {
        public int FeedbackID { get; set; }
        public int MentorshipID { get; set; }
        public int UserID { get; set; } //a mentee
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }


        //public Mentorship Mentorship { get; set; }
    }
}
