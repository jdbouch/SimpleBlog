using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.Controllers;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespacepost = new[] { typeof(PostsController).Namespace };
            //var namespaceauth = new { typeof(AuthController).Namespace };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Login",
                "Login",
                //url: "{controller}/{action}/{id}",
                defaults: new { controller = "Auth", action = "Login" }
                );
            routes.MapRoute("Logout",
                "Logout",
                //url: "{controller}/{action}/{id}",
                defaults: new { controller = "Auth", action = "Logout" }
                );
            routes.MapRoute("Home", "",
                new { controller = "Posts", action = "Index" }, 
                namespaces :new [] {"SimpleBlog.Areas.PostController"}
            );
        }
    }
}
