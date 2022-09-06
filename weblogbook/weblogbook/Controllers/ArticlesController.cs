using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace weblogbook.Controllers
{
    [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
    public class ArticlesController : Controller
    {
        // GET: Articles
        public ActionResult Index()
        {
            if (Session["user"] == null) return RedirectToAction("Index", "Door");
            return View();
        }

        // GET: Articles/Details/5
        public ActionResult Details(int id)
        {if (Session["user"] == null)
                return RedirectToAction("Index", "Door");
            
            return View();
        }

        // GET: Articles/Create
        public ActionResult Create()
        {
            if (Session["user"] == null) return RedirectToAction("Index", "Door");
            return RedirectToAction("Feed", "Feed");
        }

        // POST: Articles/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "title, articleBody, image")] Models.Article article)
        {

            // TODO: Add insert logic here
            String uid = (String)Session["user"];
            Models.SDEntities sddb = new Models.SDEntities();
            Models.User thisuser = sddb.Users.Where(usr => usr.username.Equals(uid)).First();
            article.writer_email = thisuser.email;
            article.writer_sl = thisuser.sl;
            article.createdAt = DateTime.Now;
            sddb.Articles.Add(article);
            try
            {
                sddb.SaveChanges();
                return RedirectToAction("Feed", "Feed");
            }
            catch(Exception)
            {
                if (Session["user"] == null) return RedirectToAction("Index", "Door");
                return View("Index");
            }
        }

        // GET: Articles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Articles/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Articles/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Articles/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
