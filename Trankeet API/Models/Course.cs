namespace Trankeet_API.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MentorID { get; set; }
        public string Category { get; set; }
        public string Subject { get; set; }
        public decimal Price { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EnrollmentDeadline { get; set; }
        public ICollection<CourseMaterial> CourseMaterials { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
