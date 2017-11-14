using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolSite.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "App for grading students assignments.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hello.";

            return View();
        }
    }
}