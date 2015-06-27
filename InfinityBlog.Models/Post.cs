using System;
using System.Collections.Generic;
using System.Linq;

namespace InfinityBlog.Models
{
    public class Post
    {
        public Post()
        {
            this.Tags = new HashSet<Tag>();
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public bool IsPinned { get; set; }

        public bool IsHidden { get; set; }
    }
}
