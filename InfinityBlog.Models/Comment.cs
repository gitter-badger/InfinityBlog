namespace InfinityBlog.Models
{
    using System;
    using System.Linq;

    public class Comment
    {
        public int Id { get; set; }
        
        public string Content { get; set; }

        public DateTime Date { get; set; }

        public virtual Person Author { get; set; }
    }
}
