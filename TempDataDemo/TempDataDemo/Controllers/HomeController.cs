using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempDataDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message1"] = "Welcome to C-Sharp from viewdata";
            ViewBag.Message2 = "Welcome to C-Sharp from viewbag";
            TempData["Message3"]= "Welcome to C-Sharp from Tempdata";

            //string[] games = { "Cricket","Football","Vollyball","BaseBall" };
            //TempData["GamesArray"] = games;
            //return View();
            return RedirectToAction("About");
        }

        public ActionResult About()
        {
            TempData.Keep();
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }
}