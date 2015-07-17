namespace InfinityBlog.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using InfinityBlog.Data.Migrations;
    using InfinityBlog.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class InfinityBlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public InfinityBlogDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<InfinityBlogDbContext, Configuration>());
        }

        public IDbSet<Post> Posts { get; set; }

        public IDbSet<Comment> Comments { get; set; }

        public IDbSet<Tag> Tags { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Project> Projects { get; set; }

        public IDbSet<Message> Messages { get; set; }

        public static InfinityBlogDbContext Create()
        {
            return new InfinityBlogDbContext();
        }
    }
}
