using StronglyType_HTML_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyType_HTML_Helper.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculation c)
        {
            int num1 = c.num1;
            int num2 = c.num2; 
            int result=num1 + num2;

            ViewBag.result=result;
            return View();
        }
    }
}