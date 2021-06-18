using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudMvc.Models;

namespace CrudMvc.Controllers
{
    public class UserController : Controller
    {
         private CRUBEntities db = new CRUBEntities();
        // GET: User
        

        public ActionResult Index(string searchString)
        {
            using (CRUBEntities db = new CRUBEntities())
            {
                
                    //use= (User)db.User.Where(s => s.Ten.StartsWith(searchString));
                    return View(db.User.Where(x => x.Ten.Contains(searchString) || searchString == null).ToList());
            
            }
                     
        }


        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            using (CRUBEntities db= new CRUBEntities())
            {
                return View(db.User.Where(x=>x.Id==id).FirstOrDefault());
            }
            
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User use)
        {
            try
            {
                // TODO: Add insert logic here
                using (CRUBEntities db = new CRUBEntities())
                {
                    db.User.Add(use);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            using (CRUBEntities db = new CRUBEntities())
            {
                return View(db.User.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User use)
        {
            try
            {
                   // TODO: Add update logic here
                using(CRUBEntities db= new CRUBEntities())
                {
                    db.Entry(use).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            using (CRUBEntities db = new CRUBEntities())
            {
                return View(db.User.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User use)
        {
            try
            {
                // TODO: Add delete logic here
                using (CRUBEntities db = new CRUBEntities())
                {
                    use = db.User.Where(x => x.Id == id).FirstOrDefault();
                    db.User.Remove(use);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
