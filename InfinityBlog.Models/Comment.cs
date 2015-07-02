using System;
using System.Linq;

namespace InfinityBlog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        
        public string Content { get; set; }

        public DateTime Date { get; set; }

        public virtual Person Author { get; set; }
    }
}
