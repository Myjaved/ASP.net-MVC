using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapDemo.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        public ViewResult Login()
        {
            return View();
        }
    }
}