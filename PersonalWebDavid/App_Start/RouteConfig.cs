using PersonalWebDavid.FiltersAndClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PersonalWebDavid
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Add routes
            routes.Add(new DomainRouteData());

            // Home
            routes.MapRoute(
                name: "Welcome",
                url: "{language}/",
                defaults: new { language = "en", controller = "Home", action = "Welcome" }
            );

            // About
            routes.MapRoute(
                name: "About",
                url: "{language}/" + url.url.aboutSection,
                defaults: new { language = "en", controller = "Home", action = "About" }
            );

            // Projects
            routes.MapRoute(
                name: "Projects",
                url: "{language}/" + url.url.projectsSection,
                defaults: new { language = "en", controller = "Home", action = "Projects" }
            );

            // Cv
            routes.MapRoute(
                name: "Cv",
                url: "{language}/" + url.url.cvPage,
                defaults: new { language = "en", controller = "Home", action = "Cv" }
            );

            // Blog
            //routes.MapRoute(
            //    name: "Blog",
            //    url: "{language}/" + url.url.blogSection,
            //    defaults: new { language = "en", controller = "Home", action = "Blog" }
            //);

            // Contact
            routes.MapRoute(
                name: "Contact",
                url: "{language}/" + url.url.contactSection,
                defaults: new { language = "en", controller = "Home", action = "Contact" }
            );

            // First level =========================================
            // 1.- Supeco
            routes.MapRoute(
                name: "Supeco",
                url: "{language}/" + url.url.projectsSection + "/" + url.url.supecoSection2,
                defaults: new { language = "en", controller = "ProjectItems", action = "Supeco"}
            );

            // 2.- Abengoa
            routes.MapRoute(
                name: "Abengoa",
                url: "{language}/" + url.url.projectsSection + "/" + url.url.abengoaSection2,
                defaults: new { language = "en", controller = "ProjectItems", action = "Abengoa" }
            );

            // 3.- Sabic
            routes.MapRoute(
                name: "Sabic",
                url: "{language}/" + url.url.projectsSection + "/" + url.url.sabicSection2,
                defaults: new { language = "en", controller = "ProjectItems", action = "Sabic" }
            );

            // 4.- Mercedes
            routes.MapRoute(
                name: "Mercedes",
                url: "{language}/" + url.url.projectsSection + "/" + url.url.mercedesSection2,
                defaults: new { language = "en", controller = "ProjectItems", action = "Mercedes" }
            );

            // 5.- Avalibrary
            routes.MapRoute(
                name: "Avalibrary",
                url: "{language}/" + url.url.projectsSection + "/" + url.url.avalibrarySection2,
                defaults: new { language = "en", controller = "ProjectItems", action = "Avalibrary" }
            );

            // 6.- JmHermanos
            routes.MapRoute(
                name: "JmHermanos",
                url: "{language}/" + url.url.projectsSection + "/" + url.url.jmhermanosSection2,
                defaults: new { language = "en", controller = "ProjectItems", action = "JmHermanos" }
            );


            // Default route to be used for httppost action method
            routes.MapRoute(
                name: "def2",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
