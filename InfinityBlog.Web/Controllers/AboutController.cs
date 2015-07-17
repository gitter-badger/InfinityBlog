namespace InfinityBlog.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using InfinityBlog.Web.Models;

    public class AboutController : BaseController
    {
        // GET: About
        public ActionResult Index()
        {
            var model = new BaseViewModel("About me");
            return this.View(model);
        }
    }
}