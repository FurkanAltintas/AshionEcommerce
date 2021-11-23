using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "LoginEmployee",
                url: "u/auth-login",
                defaults: new { controller = "Account", action = "LoginEmployee" }
            );

            routes.MapRoute(
                name: "AccountReg",
                url: "register",
                defaults: new { controller = "Account", action = "Register" }
            );

            routes.MapRoute(
                name: "AccountLog",
                url: "login",
                defaults: new { controller = "Account", action = "Login" }
            );

            routes.MapRoute(
                name: "Product",
                url: "p/{product}-{id}",
                defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Brand",
                url: "b/{brand}",
                defaults: new { controller = "Product", action = "Brand", String = "" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
