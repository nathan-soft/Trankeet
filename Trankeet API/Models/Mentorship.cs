namespace Trankeet_API.Models
{
    public class Mentorship
    {
        public int MentorshipID { get; set; }
        public int MentorID { get; set; }
        public int MenteeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public User Mentor { get; set; }
        public User Mentee { get; set; }
    }
}
