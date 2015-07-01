using System;
using System.Linq;
using System.Web.Mvc;
using InfinityBlog.Web.Models;

namespace InfinityBlog.Web.Controllers
{
    public class ContactController : BaseController
    {
        // GET: Contact
        public ActionResult Index()
        {
            var model = new BaseViewModel("Contact me");
            return View(model);
        }
    }
}