﻿using System;
using System.Linq;

namespace InfinityBlog.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public Person Author { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }
    }
}
