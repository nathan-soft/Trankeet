namespace Trankeet_API.Models
{
    public class PostComment
    {
        public int CommentID { get; set; }
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }

        //public BlogPost Post { get; set; }
        //public User User { get; set; }
    }
}
