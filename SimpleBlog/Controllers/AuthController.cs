using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {

        // GET: Auth
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }
        public ActionResult Login()
        {
            return View(new AuthLogin
            {
               
            });
        }
        // POST: authLogin using Form
        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnurl)
        {
            if (!ModelState.IsValid)
                return View(form);

            FormsAuthentication.SetAuthCookie(form.Username, true); 
            if (!string.IsNullOrWhiteSpace(returnurl))
                return Redirect(returnurl);

            return RedirectToRoute("home");
        }
    }
}