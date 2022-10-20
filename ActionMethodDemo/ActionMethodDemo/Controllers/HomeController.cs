using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionMethodDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string show()
        {
            return "This is second action method of Home Controller";
        }

        public ActionResult AboutUs()
        {
            return View();
       
        } 
        public int StudentID(int ID) 
        {
            return ID;
        }

    }
}