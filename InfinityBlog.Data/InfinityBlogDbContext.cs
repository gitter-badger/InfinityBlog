using System;
using System.Data.Entity;
using System.Linq;
using InfinityBlog.Data.Migrations;
using InfinityBlog.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InfinityBlog.Data
{
    public class InfinityBlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public InfinityBlogDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<InfinityBlogDbContext, Configuration>());
        }

        public static InfinityBlogDbContext Create()
        {
            return new InfinityBlogDbContext();
        }

        public IDbSet<Post> Posts { get; set; }

        public IDbSet<Author> Authors { get; set; }

        public IDbSet<Comment> Comments { get; set; }

        public IDbSet<Tag> Tags { get; set; }
    }
}
