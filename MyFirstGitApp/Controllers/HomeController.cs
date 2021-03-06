﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstGitApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Fetch application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Fetch contact page.";

            return View();
        }
    }
}
