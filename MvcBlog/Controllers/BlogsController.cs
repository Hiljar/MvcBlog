using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBlog.Models;

namespace MvcBlog.Controllers
{
   
    public class BlogsController : Controller
    {
        private MovieDBContext db = new MovieDBContext();
        
    
        //
        // GET: /Blogs/

        public ViewResult Index()
        {
            return View(db.Blogs.ToList());
        }

         [Authorize(Roles = "Administrator")]
    
    
        //
        // GET: /Blogs/Details/5

        public ViewResult Details(int id)
        {
            Blog blog = db.Blogs.Find(id);
            return View(blog);
        }



    [Authorize(Roles = "Administrator")]
    
        //
        // GET: /Blogs/Create

        public ActionResult Create()
        {
            return View();
        } 


      [Authorize(Roles = "Administrator")]
    
        //
        // POST: /Blogs/Create

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(blog);
        }

          [Authorize(Roles = "Administrator")]
    
        //
        // GET: /Blogs/Edit/5
 
        public ActionResult Edit(int id)
        {
            Blog blog = db.Blogs.Find(id);
            return View(blog);
        }

          [Authorize(Roles = "Administrator")]
    
        //
        // POST: /Blogs/Edit/5

        [HttpPost]
        public ActionResult Edit(Blog blog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

          [Authorize(Roles = "Administrator")]
    
        //
        // GET: /Blogs/Delete/5
 
        public ActionResult Delete(int id)
        {
            Blog blog = db.Blogs.Find(id);
            return View(blog);
        }

          [Authorize(Roles = "Administrator")]
    
        //
        // POST: /Blogs/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Blog blog = db.Blogs.Find(id);
            db.Blogs.Remove(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    
        
      
          
      
    }

}