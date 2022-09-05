using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace weblogbook.Controllers
{




    public class FeedController : Controller
    {
       // Models.WeblogDBEntities1 db = new Models.WeblogDBEntities1();
        Models.SDEntities sddb = new Models.SDEntities();

      
        public ActionResult Feed()
        {



            // if (Session["user"] == null)
            //{
            //    Response.Redirect("~/Door/Index");
            // }
            if (User.Identity.IsAuthenticated) return View();
            return RedirectToAction("Index", "Door");
            //return View("~/Views/Door/Index.cshtml");
        }
       



        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            Session["user"] = null;
            Session.Clear();

            Session.Abandon();
            HttpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            return RedirectToAction("Index", "Door");
        }

    }




}