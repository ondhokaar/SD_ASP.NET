using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace weblogbook.Controllers
{
    [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
    public class SubscriptionsController : Controller
    {
        Models.SDEntities sddb = new Models.SDEntities();
        // GET: Subscriptions
        public ActionResult Index()
        {
            if (Session["user"] == null) return RedirectToAction("Index", "Door");
            return View();
        }

        [HttpPost]

        public ActionResult Buy()
        {
            ViewBag.Buy = true;
            ViewBag.Pack = "something";
            return RedirectToAction("Buy");
        }

        [HttpPost]
        public ActionResult AddNew(Models.subscription newsub)
        {
            newsub.postby = (String)Session["user"];
            sddb.subscriptions.Add(newsub);
            try
            {
                sddb.SaveChanges();

            }
            catch { }
            if (Session["user"] == null) return RedirectToAction("Index", "Door");
            return View("Index");
        }
    }
}