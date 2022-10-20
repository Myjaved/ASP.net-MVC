using PracticeWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeWebApplication1.Controllers
{
    public class LoginController : Controller
    {
        PracticeMVCEntities3 db=new PracticeMVCEntities3();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(user u)
        {
            if(ModelState.IsValid==true)
            {
                db.users.Add(u);
                int a= db.SaveChanges();
                if(a>0)
                {
                    ViewBag.Message = "Data Inserted";
                    ModelState.Clear();
                }
            }
            else 
            {
                ViewBag.Message = "Data not Inserted";
            }
            return View();
        }
    }
}