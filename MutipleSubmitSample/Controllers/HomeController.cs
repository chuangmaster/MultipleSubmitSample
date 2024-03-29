﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MutipleSubmitSample.Controllers
{
    public class HomeController : Controller
    {
        [Route("~/Index")]
        public ActionResult Index()
        {
            ViewBag.Message = TempData["Message"];
            return View();
        }

        [Route("~/About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("~/Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
