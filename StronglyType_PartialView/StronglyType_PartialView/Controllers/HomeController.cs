using StronglyType_PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyType_PartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        List<products> productsList = new List<products>()
        {
            new products{ id = 1, name ="Reebok Shoes",price =10000,picture="~/pictures/XMen.jpg"},
            new products{ id = 2, name ="Rayben Glasses",price=5000,picture="~/pictures/XMen.jpg"},
            new products{ id = 3, name ="Mufti Jeans",price=2000,picture="~/pictures/XMen.jpg"},

        };

        public ActionResult Index()
        {

            return View(productsList);
        }

       
    }
}