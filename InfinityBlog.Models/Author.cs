﻿using System;
using System.Linq;

namespace InfinityBlog.Models
{
    public class Author
    {
        // TODO: Add inheritance from Person

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }
    }
}
