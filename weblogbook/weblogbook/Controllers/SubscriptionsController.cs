using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace weblogbook.Controllers
{
    public class SubscriptionsController : Controller
    {
        // GET: Subscriptions
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
        public ActionResult Buy()
        {
            ViewBag.Buy = true;
            ViewBag.Pack = "something";
            return RedirectToAction("Buy");
        }
    }
}