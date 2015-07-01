using System;
using System.Linq;
using System.Web.Mvc;

namespace InfinityBlog.Web.Controllers
{
    public class ProjectsController : BaseController
    {
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }
    }
}