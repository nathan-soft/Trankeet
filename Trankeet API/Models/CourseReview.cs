namespace Trankeet_API.Models
{
    public class CourseReview
    {
        public int ReviewID { get; set; }
        public int CourseID { get; set; }
        public int UserID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }


        //public Course Course { get; set; }
        //public User User { get; set; }
    }
}
