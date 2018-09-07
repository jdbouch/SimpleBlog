﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View(new AuthLogin
            {
               
            });
        }
        // POST: authLogin using Form
        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
                return View(form);
            
            if (form.Username != "rainbow dash")
            {
                ModelState.AddModelError("Username", "user name or password is not valid");
                    return View(form);
            }
            return Content("The form is valid");
        }
    }
}