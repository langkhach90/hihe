using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HiHe
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           
            routes.MapRoute(
               name: "Product Detail",
               url: "chi-tiet/{metatitle}-{id}",
               defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
               namespaces: new string[] { "HiHe.Controllers" }
           );
            routes.MapRoute(
              name: "Product Category",
              url: "sanpham/{metatitle}-{CategoryId}",
              defaults: new { controller = "Product", action = "GetListProductCategory", id = UrlParameter.Optional },
              namespaces: new string[] { "HiHe.Controllers" }
          );
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
               namespaces: new string[] { "HiHe.Controllers" }
           );
        }
    }
}
