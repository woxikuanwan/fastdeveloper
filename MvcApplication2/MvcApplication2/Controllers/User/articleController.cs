using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers.User
{
    public class articleController : Controller
    {
        private articleEnf db = new articleEnf();

        //
        // GET: /article/

        public ActionResult Index()
        {
            return View(db.article.ToList());
            
        }

        //
        // GET: /article/Details/5

        public ActionResult Details(int id = 0)
        {
            article article = db.article.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //
        // GET: /article/Create

        public ActionResult Create()
        {
            ViewData["test1"] = "sadf";
            return View();
        }

        //
        // POST: /article/Create

        [HttpPost]
        public ActionResult Create(article article)
        {
            string a = Request["text1"];
            if (ModelState.IsValid)
            {
                db.article.Add(article);
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }

            return View(article);
        }

        //
        // GET: /article/Edit/5

        public ActionResult Edit(int id = 0)
        {
            article article = db.article.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //
        // POST: /article/Edit/5

        [HttpPost]
        public ActionResult Edit(article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }

        //
        // GET: /article/Delete/5

        public ActionResult Delete(int id = 0)
        {
            article article = db.article.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //
        // POST: /article/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            article article = db.article.Find(id);
            db.article.Remove(article);
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