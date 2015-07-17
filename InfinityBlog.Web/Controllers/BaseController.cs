namespace InfinityBlog.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using InfinityBlog.Data;

    public class BaseController : Controller
    {
        public BaseController()
        {
            this.DbContext = new InfinityBlogDbContext();
        }

        public InfinityBlogDbContext DbContext { get; set; }
    }
}