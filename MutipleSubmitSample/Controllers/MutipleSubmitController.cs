using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using MutipleSubmitSample.Attribute;

namespace MutipleSubmitSample.Controllers
{
    public class MutipleSubmitController : Controller
    {
        [Route("~/Sample")]
        public ActionResult Index()
        {
            return View();
        }

        [MultipleButton(Name = "action", Argument = "Save")]
        [Route("~/Result")]
        public ActionResult Save()
        {
            TempData["Message"] = "Save";
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        [MultipleButton(Name = "action", Argument = "Cancel")]
        [Route("~/Result")]
        public ActionResult Cancel()
        {
            TempData["Message"] = "Cancel";
            return RedirectToRoute(new {controller = "Home", action = "Index"});
        }
    }
}