namespace InfinityBlog.Models
{
    using System;
    using System.Linq;

    public class Message
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public virtual Person Sender { get; set; }
    }
}
