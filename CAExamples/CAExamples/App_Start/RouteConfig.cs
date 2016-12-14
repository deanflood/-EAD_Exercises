using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CAExamples
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Student", action = "Index"}
);

            routes.MapRoute(
                name: "StudentRoute",
                url: "Student/{action}/{name}/{age}",
                defaults: new { controller = "Student", action = "Index", name = "Dean", age = 10 }
            );

            routes.MapRoute(
                   name: "RedundancyRoute",
                   url: "AzureStorage/{action}/{size}/{redundancy}",
                   defaults: new { controller = "AzureStorage", action = "Index", size = UrlParameter.Optional, redundancy = UrlParameter.Optional }

);
        }
    }
}
