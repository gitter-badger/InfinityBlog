using System;
using System.Linq;
using System.Web.Mvc;
using InfinityBlog.Data;

namespace InfinityBlog.Web.Models
{
    public abstract class BaseController : Controller
    {
        public BaseController()
        {
            this.DbContext = new InfinityBlogDbContext ();
        }

        public InfinityBlogDbContext DbContext { get; set; }
    }
}