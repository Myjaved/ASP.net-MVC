using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDataDemo.Models;

namespace ViewDataDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message"] = "Message from view data";
            ViewData["CurrentTime"]=DateTime.Now.ToLongTimeString();

            
            string[] fruits = { "Apple", "Banana", "Mango", "Kivi" };
            ViewData["FruitsArray"] = fruits;

            
            ViewData["SportList"] = new List<string>()
            {
                "Cricket",
                "Football",
                "Hockey",
                "Baseball"
            };

            Employee Ali = new Employee();
            Ali.EmpID = 20;
            Ali.EmpName = "Ali khan";
            Ali.EmpDesignation = "Manager";

            ViewData["Employee"]=Ali;

            return View(); 
        }

        public ActionResult About()
        {
            
            return View();
        }

        
    }
}