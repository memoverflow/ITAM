using System.Web;
using System.Web.Optimization;

namespace ITAM.Portal
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/ionicons.min.css",
                      "~/Scripts/plugins/datatables/dataTables.bootstrap.css",
                      "~/Scripts/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                      "~/Content/site.css"));

            //register adminlte theme for the web
            bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                      "~/Scripts/adminlte.js",
                      "~/Scripts/demo.js",
                      "~/Scripts/plugins/slimScroll/jquery.slimscroll.min.js",
                      "~/Scripts/plugins/chartjs/Chart.min.js"
                      ));
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                      "~/Scripts/app.js"
                      ));
            bundles.Add(new StyleBundle("~/Content/adminltecss").Include(
                      "~/Content/AdminLTE.css",
                      "~/Content/_all-skins.css"));

        }
    }
}
