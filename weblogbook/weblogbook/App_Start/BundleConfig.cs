using System.Web;
using System.Web.Optimization;

namespace weblogbook
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                                  "~/Scripts/myjs.js",
                                  "~/Scripts/bootstrap.js",
                                  "~/Scripts/bootstrap.bundle.js",
                                  "~/Scripts/bootstrap.bundle.js.map",
                                  "~/Scripts/bootstrap.bundle.min.js",
                                  "~/Scripts/bootstrap.bundle.min.js.map",
                                  "~/Scripts/bootstrap.esm.js",
                                  "~/Scripts/bootstrap.esm.js.map",
                                  "~/Scripts/bootstrap.esm.min.js",
                                  "~/Scripts/bootstrap.esm.min.js.map",
                                  "~/Scripts/bootstrap.js",
                                  "~/Scripts/bootstrap.js.map",
                                  "~/Scripts/bootstrap.min.js",
                                  "~/Scripts/bootstrap.min.js.map",
                                  "~/Scripts/jquery-3.4.1.intellisense.js",
                                  "~/Scripts/jquery-3.4.1.js",
                                  "~/Scripts/jquery-3.4.1.min.js",
                                  "~/Scripts/jquery-3.4.1.min.map",
                                  "~/Scripts/jquery-3.4.1.slim.js",
                                  "~/Scripts/jquery-3.4.1.slim.min.js",
                                  "~/Scripts/jquery-3.4.1.slim.min.map",
                                  "~/Scripts/jquery.validate-vsdoc.js",
                                  "~/Scripts/jquery.validate.js",
                                  "~/Scripts/jquery.validate.min.js",
                                  "~/Scripts/jquery.validate.unobtrusive.js",
                                  "~/Scripts/jquery.validate.unobtrusive.min.js",
                                  "~/Scripts/modernizr-2.8.3.js"
                                  ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-grid.css",
                      "~/Content/bootstrap-grid.css.map",
                      "~/Content/bootstrap-grid.min.css",
                      "~/Content/bootstrap-grid.min.css.map",
                      "~/Content/bootstrap-grid.rtl.css",
                      "~/Content/bootstrap-grid.rtl.css.map",
                      "~/Content/bootstrap-grid.rtl.min.css",
                      "~/Content/bootstrap-grid.rtl.min.css.map",
                      "~/Content/bootstrap-reboot.css",
                      "~/Content/bootstrap-reboot.css.map",
                      "~/Content/bootstrap-reboot.min.css",
                      "~/Content/bootstrap-reboot.min.css.map",
                      "~/Content/bootstrap-reboot.rtl.css",
                      "~/Content/bootstrap-reboot.rtl.css.map",
                      "~/Content/bootstrap-reboot.rtl.min.css",
                      "~/Content/bootstrap-reboot.rtl.min.css.map",
                      "~/Content/bootstrap-utilities.css",
                      "~/Content/bootstrap-utilities.css.map",
                      "~/Content/bootstrap-utilities.min.css",
                      "~/Content/bootstrap-utilities.min.css.map",
                      "~/Content/bootstrap-utilities.rtl.css",
                      "~/Content/bootstrap-utilities.rtl.css.map",
                      "~/Content/bootstrap-utilities.rtl.min.css",
                      "~/Content/bootstrap-utilities.rtl.min.css.map",
                      "~/Content/bootstrap.css.map",
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap.min.css.map",
                      "~/Content/bootstrap.rtl.css",
                      "~/Content/bootstrap.rtl.css.map",
                      "~/Content/bootstrap.rtl.min.css",
                      "~/Content/bootstrap.rtl.min.css.map",
                      "~/Content/Site.css",

                      "~/Content/mycss/login-style.css"
                      ));
        }
    }
}
