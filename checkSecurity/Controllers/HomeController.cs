using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using checkSecurity.Models;

namespace checkSecurity.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
          // return RedirectToAction("Details", new { userId=99, password="abc"});
        }
        //[HttpPost]
        //public ActionResult Index(UserAuthentication user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Session["User"] = user.UserName;
        //        return RedirectToAction("Details", new { userId = user.UserName, password = user.Password });
        //    }
        //    return View();
        //    // 
        //}
       
    }
}