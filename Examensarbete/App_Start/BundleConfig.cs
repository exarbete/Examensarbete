using System.Web;
using System.Web.Optimization;

namespace Examensarbete
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Extra bundles added for this application

            bundles.Add(new StyleBundle("~/bundles/ELwebshop/style").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/app.css"));

            bundles.Add(new ScriptBundle("~/bundles/ELwebshop/script").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-route.js",
                      "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                      "~/Selection_Routing/Selection_Product_Routing/Routing_Page.js",
                      "~/Selection_Routing/Selection_Product/Home.js",
                      "~/Selection_Routing/Selection_Product/Computer.js",
                      "~/Selection_Routing/Selection_Product/Telephone.js",
                      "~/Selection_Routing/Selection_Product/Accessories.js",
                      "~/Selection_Routing/Selection_Product/Menu.js"
                      ));





        }
    }
}
