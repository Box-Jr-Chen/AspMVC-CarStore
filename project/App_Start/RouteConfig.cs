using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "Car",
             url: "Car",
             defaults: new { controller = "Car", action = "Index" }
             );

            routes.MapRoute(
             name: "FindCarByBrand",
             url: "Car/Brand/{brand}",
             defaults: new { controller = "Car", action = "FindBrand",brand=UrlParameter.Optional }
             );

            routes.MapRoute(
                 name: "CarCategory",
                 url: "Car/Cat/{Category}",
                 defaults: new { controller = "Car", action = "FindCategory", Category = "轎車" }
                 );
            routes.MapRoute(
                 name: "FindCarById",
                 url: "Car/Id/{Id}",
                 defaults: new { controller = "Car", action = "FindId", id = UrlParameter.Optional}
                 );

            routes.MapRoute(
                 name: "FindCarByYear",
                 url: "Car/Year/{year}",
                 defaults: new { controller = "Car", action = "FindYear", year = 2017 },
                 constraints: new { year = @"\d{4}" }
                 );

            routes.MapRoute(
                 name: "FindCarByBrandYear",
                 url: "Car/Brand-Year/{brand}-{year}",
                 defaults: new { controller = "Car", action = "FindBrandYear"},
                 constraints: new { brand = @"\w+", year = @"\d{4}" }
                 );

            //7.Car/TopSales/{topnumber}
            routes.MapRoute(
                name: "CarTopSales",
                url: "Car/TopSales/{topnumber}",
                defaults: new { controller = "Car", action = "TopSales", topnumber = 5 },
                constraints: new { topnumber = @"[1-9]+[0-9]*" }
            );

            routes.MapRoute(
                name: "GetRouteData",
                url: "Car/Route/{RouteParam}",
                defaults: new { controller = "Car", action = "GetRouteData", RouteParam = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
