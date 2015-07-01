using System;
using System.Linq;
using System.Web.Mvc;
using InfinityBlog.Web.Models;

namespace InfinityBlog.Web.Controllers
{
    public class ProjectsController : BaseController
    {
        // GET: Projects
        public ActionResult Index()
        {
            var model = new BaseViewModel("Home");
            return View(model);
        }
    }
}