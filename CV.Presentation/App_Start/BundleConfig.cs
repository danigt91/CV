using System.Web;
using System.Web.Optimization;

namespace CV
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/libs/jquery/jquery-{version}.js"));*/

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/libs/modernizr/modernizr-*"));

            /*bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/libs/bootstrap/bootstrap.js",
                      "~/Scripts/libs/respond/respond.js"));*/

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/lib/bootstrap/bootstrap.css",
                      "~/Content/site.css"));

            /*bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/libs/angular/angular.js",
                "~/Scripts/libs/angular-ui-router/angular-ui-router.js"
                ));
            */

            /*bundles.Add(new ScriptBundle("~/bundles/angularApp").Include(
                // APP
                "~/Scripts/app.js",
                // CONTROLLERS
                "~/Scripts/controllers/App/AppCtrl.js",
                "~/Scripts/controllers/Menu/MenuPublicCtrl.js"
                ));
            */
        }
    }
}
