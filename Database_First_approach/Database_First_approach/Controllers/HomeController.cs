using Database_First_approach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Database_First_approach.Controllers
{
    public class HomeController : Controller
    {
        DatabaseFirstEFEntities db = new DatabaseFirstEFEntities(); 
        // GET: Home
        public ActionResult Index()
        {
            var data = db.students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(student s)
        {
            if(ModelState.IsValid==true)
            {
                db.students.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["InsertMessage"] = "Data Inserted Successfully!!!";
                    return RedirectToAction("Index");
                    //ViewBag.InsertMessage = "Data Inserted Successfully!!!";
                    //ModelState.Clear();
                }
                else
                {
                    ViewBag.InsertMessage = "Data Not Inserted !";
                }
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.students.Where(model => model.id == id).FirstOrDefault();
            return View(row);
        }


        [HttpPost]
        public ActionResult Edit(student s)
        {
            if(ModelState.IsValid==true)
            {
                db.Entry(s).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["UpdateMessage"] = "Data Edited successfully!!!";
                    return RedirectToAction("Index");
                    //ViewBag.UpdateMessage = "Data Edited successfully!!!";
                    //ModelState.Clear();
                }
                else
                {
                    ViewBag.UpdateMessage = "Data Not Updated!";
                }
            }
            
            return View();
        }
        
        
        public ActionResult Delete(int id)
        {
            var DeleteRow=db.students.Where(model => model.id==id).FirstOrDefault();
            return View(DeleteRow);
        }


        [HttpPost]
        public ActionResult Delete(student s)
        {
            if(ModelState.IsValid ==true)
            {
                db.Entry(s).State = EntityState.Deleted;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["DeleteMessage"] = "Data Deleted successfully!!!";
                    return RedirectToAction("Index");
                    //ViewBag.DeleteMessage = "Data Deleted successfully!!!";
                    //ModelState.Clear();
                }
                else
                {
                    ViewBag.DeleteMessage = "Data Not Deleted !";
                }
            }
            
            return View();
        }

        public ActionResult Details(int id)
        {
            var Row = db.students.Where(model => model.id == id).FirstOrDefault();
            return View(Row);
        }

    }
}