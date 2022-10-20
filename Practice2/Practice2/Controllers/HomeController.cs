using Practice2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice2.Controllers
{
    public class HomeController : Controller
    {
        DatabaseFirstEFEntities1 db = new DatabaseFirstEFEntities1();
        public ActionResult Index()
        {
            var data = db.students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}