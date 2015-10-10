﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplicationDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Employee",
                "Employee/{name}",
                new { controller = "Employee", action = "Search", name = UrlParameter.Optional }
                );

            //routes.MapRoute("Employee",
            //    "employee/{name}",
            //    new { controller = "Employee", action = "Search", name = UrlParameter.Optional }
            //    );


            routes.MapRoute("Cuisine",
                "cuisine/{name}",
                new { controller = "Cuisine", action = "Search", name = UrlParameter.Optional });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }
    }
}