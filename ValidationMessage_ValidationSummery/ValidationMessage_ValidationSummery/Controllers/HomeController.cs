using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ValidationMessage_ValidationSummery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        string Emailpattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string fullname,string Age,string Email)
        {
            if (fullname.Equals("")==true)
            {
                ModelState.AddModelError("fullname", "full name is required");
                ViewData["fullnameError"] = "*";
            }
            if (Age.Equals("") == true)
            {
                ModelState.AddModelError("Age", "Age name is required");
                ViewData["AgeError"] = "*";
            }
            if (Email.Equals("") == true)
            {
                ModelState.AddModelError("Email", "Email is required");
                ViewData["EmailError"] = "*";
            }

            if(ModelState.IsValid == true)
            {
                ViewData["SuccessMessage"] = "<script>alert('Data has beem submitted)<script/>";
                ModelState.Clear();
            }
            else
            {
                if(Regex.IsMatch(Email,Emailpattern)==false)
                {
                    ModelState.AddModelError("Email", "Email invalid");
                    ViewData["EmailError"] = "*";
                }
            }

            return View();
        }
    }
}