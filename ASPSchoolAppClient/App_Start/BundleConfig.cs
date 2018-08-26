using System.Web;
using System.Web.Optimization;

namespace ASPSchoolAppClient
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

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Js").Include(
                      //"~/Content/AdminLTE/bower_components/jquery/dist/jquery.min.js",
                      "~/Content/AdminLTE/bower_components/jquery-ui/jquery-ui.min.js",
                      "~/Content/AdminLTE/bower_components/bootstrap/dist/js/bootstrap.min.js",
                      "~/Content/AdminLTE/bower_components/raphael/raphael.min.js",
                      "~/Content/AdminLTE/bower_components/morris.js/morris.min.js",
                      "~/Content/AdminLTE/bower_components/jquery-sparkline/dist/jquery.sparkline.min.js",
                      "~/Content/AdminLTE/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                      "~/Content/AdminLTE/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                      "~/Content/AdminLTE/bower_components/jquery-knob/dist/jquery.knob.min.js",
                      "~/Content/AdminLTE/bower_components/moment/min/moment.min.js",
                      "~/Content/AdminLTE/bower_components/bootstrap-daterangepicker/daterangepicker.js",
                      "~/Content/AdminLTE/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                      "~/Content/AdminLTE/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                      "~/Content/AdminLTE/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                      "~/Content/AdminLTE/bower_components/fastclick/lib/fastclick.js",
                      "~/Content/AdminLTE/dist/js/adminlte.min.js",
                      "~/Content/AdminLTE/dist/js/pages/dashboard.js",
                      "~/Content/AdminLTE/dist/js/demo.js",

                      "~/Content/AdminLTE/bower_components/select2/dist/js/select2.full.min.js",
                      "~/Content/AdminLTE/plugins/input-mask/jquery.inputmask.js",
                      "~/Content/AdminLTE/plugins/input-mask/jquery.inputmask.date.extensions.js",
                      "~/Content/AdminLTE/plugins/input-mask/jquery.inputmask.extensions.js",
                      "~/Content/AdminLTE/bower_components/bootstrap-colorpicker/dist/js/bootstrap-colorpicker.min.js",
                      "~/Content/AdminLTE/plugins/timepicker/bootstrap-timepicker.min.js",
                      "~/Content/AdminLTE/plugins/iCheck/icheck.min.js"
                      ));






















                          //bundles.Add(new StyleBundle("~/Content/css").Include(
                          //          "~/Content/bootstrap.css",
                          //          "~/Content/site.css"));

                          bundles.Add(new StyleBundle("~/Css").Include(
                      "~/Content/AdminLTE/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/AdminLTE/bower_components/font-awesome/css/font-awesome.min.css",
                      "~/Content/AdminLTE/bower_components/Ionicons/css/ionicons.min.css",
                      "~/Content/AdminLTE/dist/css/AdminLTE.min.css",
                      "~/Content/AdminLTE/dist/css/skins/_all-skins.min.css",
                      "~/Content/AdminLTE/bower_components/morris.js/morris.css",
                      "~/Content/AdminLTE/bower_components/jvectormap/jquery-jvectormap.css",
                      "~/Content/AdminLTE/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                      "~/Content/AdminLTE/bower_components/bootstrap-daterangepicker/daterangepicker.css",
                      "~/Content/AdminLTE/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",

                      "~/Content/AdminLTE/plugins/iCheck/all.css",
                      "~/Content/AdminLTE/bower_components/bootstrap-colorpicker/dist/css/bootstrap-colorpicker.min.css",
                      "~/Content/AdminLTE/plugins/timepicker/bootstrap-timepicker.min.css",
                      "~/Content/AdminLTE/bower_components/select2/dist/css/select2.min.css"

                      ));
        }
    }
}

