using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginFormMVC.Models;

namespace LoginFormMVC.Controllers
{
    public class LoginController : Controller
    {
        LoginDBEntities db=new LoginDBEntities();
        // GET: Login
        public ActionResult Index()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Index (User s)
        {
            if(ModelState.IsValid==true) 
            {
                var credentials = db.Users.Where(model => model.Username == s.Username && model.Password == s.Password).FirstOrDefault();
                if(credentials==null)
                {
                    ViewBag.ErrorMessage = "Login Failed !!";
                    return View();
                }
                else 
                {
                    Session["username"] = s.Username;
                    return RedirectToAction("Index", "Home");
                } 
            }
            return View();
        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }

        public ActionResult Reset()
        {
            ModelState.Clear();
            return RedirectToAction("Index", "Login");
        }

    }
}