﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Product Category",
              url: "san-pham/{metaTitle}-{id}",
              defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional },
              namespaces: new[] { "BookShop.Controllers" }
          );
            routes.MapRoute(
              name: "Product Detail",
              url: "chi-tiet/{metaTitle}-{id}",
              defaults: new { controller = "Product", action = "Detial", id = UrlParameter.Optional },
              namespaces: new[] { "BookShop.Controllers" }
          );
            routes.MapRoute(
              name: "About",
              url: "gioi-thieu",
              defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
              namespaces: new[] { "BookShop.Controllers" }
          );
            routes.MapRoute(
             name: "Add Cart",
             url: "them-gio-hang",
             defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional },
             namespaces: new[] { "BookShop.Controllers" }
         );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces:new[] {"BookShop.Controllers"}
            );
           
        }
    }
}
