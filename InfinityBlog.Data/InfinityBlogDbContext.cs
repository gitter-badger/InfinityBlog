using System;
using System.Linq;
using InfinityBlog.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InfinityBlog.Data
{
    public class InfinityBlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public InfinityBlogDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static InfinityBlogDbContext Create()
        {
            return new InfinityBlogDbContext();
        }
    }
}
