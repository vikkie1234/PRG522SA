﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FormativeAssessment3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "About",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Contacts",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Contacts", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Account",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Portfolio",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
           );
        }
    }
}
