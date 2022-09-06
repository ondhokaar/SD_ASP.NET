using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace weblogbook.Controllers
{


    [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
    public class FeedController : Controller
    {
       // Models.WeblogDBEntities1 db = new Models.WeblogDBEntities1();
        Models.SDEntities sddb = new Models.SDEntities();

        [HttpPost]
        public ActionResult PostView()
        {
            if (Session["user"] == null) return RedirectToAction("Index", "Door");

            return RedirectToAction("Index", "Articles");
      
            
        }

        public ActionResult Feed()
        {


            //return View();  
            // if (Session["user"] == null)
            //{
            //    Response.Redirect("~/Door/Index");
            // }
            if (Session["user"] != null) return View();
            return RedirectToAction("Index", "Door");
            //return View("~/Views/Door/Index.cshtml");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Response.AppendHeader("Cache-Control", "no-store");



            Session["user"] = null;
            Session.Clear();

            Session.Abandon();
            HttpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            return RedirectToAction("Index", "Door");
        }

    }




}