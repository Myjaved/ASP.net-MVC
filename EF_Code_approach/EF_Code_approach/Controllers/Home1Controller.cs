using EF_Code_approach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_Code_approach.Controllers
{
    public class Home1Controller : Controller
    {
        readonly StudentContext db=new StudentContext();
        // GET: Home1
        public ActionResult Index()
        {
            var data=db.Students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if(ModelState.IsValid==true)
            {
                db.Students.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    //ViewBag.InsertMessage = "Data inserted";
                    TempData["InsertMessage"] = "Data inserted";
                    return RedirectToAction("Index");
                    //ModelState.Clear();
                }
                else
                {
                    ViewBag.InsertMessage = "Data not inserted";

                }
            }
            
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var row = db.Students.Where(model => model.Id == Id).FirstOrDefault();
            return View(row);
        }

        
        
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(s).State = EntityState.Modified;

                int a = db.SaveChanges();
                if (a > 0)
                {
                    //ViewBag.InsertMessage = "Data inserted";
                    TempData["UpdateMessage"] = "Data inserted";
                    return RedirectToAction("Index");
                    //ModelState.Clear();
                }
                else
                {
                    ViewBag.UpdateMessage = "Data not inserted";

                }
            }
            return View();

         
        }
        public ActionResult Delete(int Id)
        {
            var row=db.Students.Where(model => model.Id == Id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Delete(Student s)
        {
            db.Entry(s).State = EntityState.Deleted;
            int a =db.SaveChanges();
            if (a > 0)
            {
                //ViewBag.InsertMessage = "Data inserted";
                TempData["DeleteMessage"] = "Data Deleted";
                return RedirectToAction("Index");
                //ModelState.Clear();
            }
            else
            {
                ViewBag.DeleteMessage = "Data not Deleted";

            }
            return RedirectToAction("Index");
        }


        public ActionResult Details(int Id)
        {
            var DetailsById = db.Students.Where(model => model.Id == Id).FirstOrDefault();
            return View(DetailsById);
        }
    }

}