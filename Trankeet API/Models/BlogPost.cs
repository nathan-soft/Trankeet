using System.Xml.Linq;

namespace Trankeet_API.Models
{
    public class BlogPost
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorID { get; set; }
        public DateTime PublishDate { get; set; }
        public string Category { get; set; }
        public string Tag { get; set; }
        public User Author { get; set; }
        public ICollection<PostComment> Comments { get; set; }
    }
}
