namespace InfinityBlog.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using InfinityBlog.Web.Models;

    public class ProjectsController : BaseController
    {
        // GET: Projects
        public ActionResult Index()
        {
            var model = new BaseViewModel("Home");
            return this.View(model);
        }
    }
}