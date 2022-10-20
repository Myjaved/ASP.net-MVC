using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SESSIONS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Var2"] = "Data comes from ViewData";
            ViewBag.Var3 = "Data comes from ViewBag";
            TempData["Var1"] = "Data comes from Tempdata";
            Session["Var4"] = "Data comes from SessionData";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}