using Data_Annotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Data_Annotation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee e)
        {
           if(ModelState.IsValid==true)
           {
                ViewBag.SuccessMessage = ("Data has been submitted"); // can use javascript class"<script>alert<script/>";
                ModelState.Clear();
           }
            return View();
        }
    }
}