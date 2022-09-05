using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace weblogbook.Views.Door
{
    [AllowAnonymous]
    public class DoorController : Controller
    {
        //Models.WeblogDBEntities1 db = new Models.WeblogDBEntities1();
        Models.SDEntities sddb = new Models.SDEntities();
        
        // GET: Feed
        [HttpPost]
        public ActionResult Login([Bind(Include = "email, pass")] Models.User loginuser)
        {


            ViewBag.val = "";
            ViewBag.info = "";
            Models.User userAuth = null;// = new List<Models.User>();


            if (ModelState.IsValid)
            {
                userAuth = sddb.Users.Where(person => person.email == loginuser.email.ToLower()).FirstOrDefault();

            }

            if (userAuth != null)
            {
                if (userAuth.pass == loginuser.pass)
                {
                    FormsAuthentication.SetAuthCookie(userAuth.username.ToString(), false);

                    Session["user"] = userAuth.username;
                    ViewBag.info = "login success!";
                    return RedirectToAction("Feed", "Feed");
                }
                else
                {
                    TempData["val"] = "unchecked";
                    TempData["info"] = "wrong pass :(";
                    return RedirectToAction("Index", "Door");
                }

            }
            TempData["val"] = "checked";
            TempData["info"] = "I don't know you :( sign up please";

            return RedirectToAction("Index", "Door");
        }
        // GET: Door
        [HttpGet]

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Models.User newuser)
        {
            if(ModelState.IsValid)
            {
                //newuser.totalposts = 0;
                newuser.username = newuser.email.Split('@')[0];
                 sddb.Users.Add(newuser);
                try
                {
                    
                    sddb.SaveChanges();
                }
                catch (Exception)
                {
                    TempData["val"] = "unchecked";

                    TempData["info"] = "Account Exists, please login";
                    return View("Index");
                }
            }
            else
            {
                TempData["val"] = "unchecked";
                TempData["info"] = "Invalid input";
                return View("Index");
            }
 
            return View("Index");  
        }

        

    }
}