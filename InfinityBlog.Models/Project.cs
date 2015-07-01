using System;
using System.Linq;

namespace InfinityBlog.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }

        public int Progress { get; set; }
    }
}
