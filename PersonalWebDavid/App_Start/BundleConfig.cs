using System.Collections.Generic;
using System.Web;
using System.Web.Optimization;

namespace PersonalWebDavid
{
    // Get css in order
    public class PassthruBundleOrderer : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }

    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // About page - People slider
            var aboutPagePeopleSlider = new ScriptBundle("~/bundles/peopleSlider").Include(
               "~/Scripts/slider.js",
               "~/Scripts/hideUpButton.js"
                );
            aboutPagePeopleSlider.Orderer = new PassthruBundleOrderer();
            bundles.Add(aboutPagePeopleSlider);

            // Home page - Above hero and scroll hero
            var indexPage = new ScriptBundle("~/bundles/heroAbove").Include(
               "~/Scripts/scrollMessages.js",
               "~/Scripts/heroAboveFold.js",
               "~/Scripts/scrollHero.js"
                );
            indexPage.Orderer = new PassthruBundleOrderer();
            bundles.Add(indexPage);

            // Contact page - Contact screen
            var contactPageScreen = new ScriptBundle("~/bundles/contact").Include(
               "~/Scripts/screenMonitorSocial.js"
                );
            contactPageScreen.Orderer = new PassthruBundleOrderer();
            bundles.Add(contactPageScreen);
            
            // Load Javascript
            var javaScriptFiles = new ScriptBundle("~/bundles/javascript").Include(
                "~/Scripts/imagesloaded.pkgd.min.js",             
                "~/Scripts/preloader.js",
                // Plugins ========================
                "~/Scripts/power.js",
                // Your js ===========================
                "~/Scripts/plugins.js"
                );
            javaScriptFiles.Orderer = new PassthruBundleOrderer();
            bundles.Add(javaScriptFiles);

            // Load Css
            var cssFiles = new StyleBundle("~/bundles/css").Include(
                    "~/Content/preloader.css",
                    "~/Content/normalize.css",
                    // Fallbacks for safari ==============
                    "~/Content/oswaldSafari.css",
                    // Theme css ==============
                    //"~/Content/testingCss/animate.css",
                    "~/Content/animateTiny.css",                   
                    "~/Content/style(1).css",
                    "~/Content/responsive.css",
                    "~/Content/slatBlue.css",
                    // Plugins ========
                    "~/Content/reset.css",
                    "~/Content/parallaxMenu.css",
                    // Your css =================
                    "~/Content/bootstrapTiny.min.css",
                    //"~/Content/testingCss/bootstrap.min.css",
                    "~/Content/main.css", // Main
                    "~/Content/typography.css" // Fonts
                );
            cssFiles.Orderer = new PassthruBundleOrderer();
            bundles.Add(cssFiles);
        }
    }
}
