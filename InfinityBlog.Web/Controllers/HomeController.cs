﻿using System;
using System.Linq;
using System.Web.Mvc;

namespace InfinityBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}