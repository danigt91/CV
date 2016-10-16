﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CV
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "DefaultCultured",
                url: "{culture}/{controller}/{action}/{id}",
                defaults: new { culture = "en-US", controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { culture = "([a-z]{2}-[A-Z]{2})" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { culture = "en-US", controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
