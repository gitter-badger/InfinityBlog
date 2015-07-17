namespace InfinityBlog.Models
{
    using System;
    using System.Linq;

    public class Project
    {
        public int Id { get; set; }

        public int Progress { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
