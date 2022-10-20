using StronglyType_view.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyType_view.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.Age = 32;
            emp1.Name = "Tahir Hussain";

            Employee emp2 = new Employee();
            emp2.Id = 2;
            emp2.Age = 33;
            emp2.Name = "Tahir Shaikh";

            Employee emp3 = new Employee();
            emp3.Id = 3;
            emp3.Age = 30;
            emp3.Name = "Tahir Khan";

            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            return View(empList);
           

        }
    }
}