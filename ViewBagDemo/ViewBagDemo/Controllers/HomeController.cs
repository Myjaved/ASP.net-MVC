using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //LIKE VIEWDATA , VIEWBAG ALSO MAINTAIN DATA FROM CONTROLLER TO VIEW

            //SINGLE LINE MESSAGE
            ViewBag.Message = "Message from View Bag";
            ViewBag.CurrentDate = DateTime.Now.ToLongTimeString();


            //ARRAYS
            string[] fruits = { "Apple", "Mango", "Banana", "Orange" };
            ViewBag.FruitsArray= fruits;

            //LIST
            ViewBag.SportsList = new List<string>()
            {"Cricket","Football","Hockey","BaseBall"};

            //OBJECT
            Employee Asad = new Employee();
            Asad.EmpID = 15;
            Asad.EmpName = "Asad";
            Asad.EmpDesignation = "Software Engineer";

            ViewBag.Employee = Asad; 
            

            return View();
        }
    }
}