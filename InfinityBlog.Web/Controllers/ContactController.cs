namespace InfinityBlog.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using InfinityBlog.Web.Models;

    public class ContactController : BaseController
    {
        // GET: Contact
        public ActionResult Index()
        {
            var model = new BaseViewModel("Contact me");
            return this.View(model);
        }
    }
}