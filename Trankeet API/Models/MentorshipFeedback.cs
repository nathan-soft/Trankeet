namespace Trankeet_API.Models
{
    public class MentorshipFeedback
    {
        public int FeedbackID { get; set; }
        public int MentorshipID { get; set; }
        public int Rating { get; set; }
        public string FeedbackComments { get; set; }
        public DateTime Date { get; set; }


        //public Mentorship Mentorship { get; set; }
    }
}
