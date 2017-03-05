using Pipeline.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pipeline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var service = new MainService();
            var str = service.Hello("Hello", "Mike");
            ViewBag.Message = str;
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
