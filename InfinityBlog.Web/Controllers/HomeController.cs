﻿using System;
using System.Linq;
using System.Web.Mvc;

namespace InfinityBlog.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}