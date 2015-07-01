using System;
using System.Linq;

namespace InfinityBlog.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public Person Sender { get; set; }
    }
}
