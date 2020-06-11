using System.Web;
using System.Web.Optimization;

namespace Aplikasi_Karantina
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.6.2"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            RegisterKendoUI(bundles);
        }

        private static void RegisterKendoUI(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Content/kendo/js/kendo").Include(
            "~/Content/kendo/js/kendo.all.min.js",
            "~/Content/kendo/js/kendo.aspnetmvc.min.js"));

            //kendo Styles
            bundles.Add(new StyleBundle("~/Content/kendo/css/kendo").Include(
            "~/Content/kendo/css/kendo.common.min.css",
            "~/Content/kendo/css/kendo.blueopal.min.css"));

            // plugins | jquery
            bundles.Add(new ScriptBundle("~/Content/plugins/jquery/js/jQuery-2").Include(
                                         "~/Content/plugins/jquery/js/jQuery-2.1.4.min.js"));

            // plugins | jquery-validate
            bundles.Add(new ScriptBundle("~/Content/plugins/jquery-validate/js").Include(
                                         "~/Content/plugins/jquery-validate/js/jquery.validate*"));

            // plugins | jquery-ui
            bundles.Add(new ScriptBundle("~/Content/plugins/jquery-ui/js").Include(
                                         "~/Content/plugins/jquery-ui/js/jquery-ui.min.js"));
        }
    }
}
