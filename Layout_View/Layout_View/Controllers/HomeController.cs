using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layout_View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.message = "This is index page"; 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.message = "This is About Us page";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.message = "This is Contact Us page";
            return View();
        }
    }
}