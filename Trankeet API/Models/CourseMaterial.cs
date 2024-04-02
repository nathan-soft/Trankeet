namespace Trankeet_API.Models
{
    public class CourseMaterial
    {
        public int MaterialID { get; set; }
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }


        //public Course Course { get; set; }
    }
}
