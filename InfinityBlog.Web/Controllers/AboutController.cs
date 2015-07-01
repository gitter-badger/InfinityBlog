using System;
using System.Linq;
using System.Web.Mvc;

namespace InfinityBlog.Web.Controllers
{
    public class AboutController : BaseController
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
    }
}