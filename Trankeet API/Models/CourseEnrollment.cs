namespace Trankeet_API.Models
{
    public class CourseEnrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int UserID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public double Progress { get; set; }
        public Course Course { get; set; }
        public User User { get; set; }
    }
}
