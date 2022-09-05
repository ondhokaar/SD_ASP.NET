using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace weblogbook.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Articles
        public ActionResult Index()
        {
            return View();
        }

        // GET: Articles/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Articles/Create
        public ActionResult Create()
        {
            return RedirectToAction("Feed", "Feed");
        }

        // POST: Articles/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {

            // TODO: Add insert logic here

            try
            {
                return RedirectToAction("Feed", "Feed");
            }
            catch(Exception)
            {
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
