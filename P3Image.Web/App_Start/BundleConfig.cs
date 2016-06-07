using System.Web.Optimization;

namespace P3Image.Web
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
                      "~/Content/Site.css"));

            #region Angular
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/i18n/angular-locale_pt-br.js",
                "~/Scripts/angular-animate.js",
                "~/Scripts/angular-aria.js",
                "~/Scripts/angular-cookies.js",
                "~/Scripts/angular-loader.js",
                "~/Scripts/angular-messages.js",
                "~/Scripts/angular-mocks.js",
                "~/Scripts/angular-resource.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-ui-router.js",
                "~/Scripts/angular-sanitize.js",
                "~/Scripts/angular-translate.js",
                "~/Scripts/angular-scenario.js",
                "~/Scripts/angular-touch.js",
                "~/Scripts/angular-local-storage.js"

            ));

            bundles.Add(new ScriptBundle("~/bundles/angular-ui").Include(
                "~/Scripts/angular-ui/ui-bootstrap.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js",
                "~/Scripts/angular-ui/ui-utils-ieshiv.js",
                "~/Scripts/angular-ui/ui-utils.js",
                "~/Scripts/angular-ui/sortable.js",
                "~/Scripts/jquery-ui-1.11.4.js",
                "~/Scripts/select.js",
                "~/Scripts/linq.js",
                "~/Scripts/angular-aside.js"
            ));

            #endregion

            #region js plugin

            bundles.Add(new ScriptBundle("~/bundles/assets/plugins").Include(
                "~/assets/js/enquire.min.js",
                "~/assets/plugins/velocityjs/velocity.min.js",
                "~/assets/plugins/velocityjs/velocity.ui.min.js",
                "~/assets/plugins/wijets/wijets.js",
                "~/assets/plugins/codeprettifier/prettify.js",
                "~/assets/plugins/bootstrap-switch/bootstrap-switch.js",
                "~/assets/plugins/bootstrap-tabdrop/js/bootstrap-tabdrop.js",
                "~/assets/plugins/iCheck/icheck.min.js",
                "~/assets/plugins/nanoScroller/js/jquery.nanoscroller.min.js",
                "~/assets/plugins/form-jasnyupload/fileinput.js",
                "~/assets/plugins/dropzone/dropzone.js",
                "~/assets/plugins/jquery-mousewheel/jquery.mousewheel.min.js",
                "~/assets/plugins/charts-chartistjs/chartist.min.js",
                "~/assets/plugins/charts-chartistjs/chartist-plugin-tooltip.js",
                "~/assets/plugins/charts-chartjs/Chart.js",
                "~/assets/plugins/easypiechart/jquery.easypiechart.js",
                "~/assets/plugins/sparklines/jquery.sparklines.min.js",
                "~/assets/plugins/switchery/switchery.js"
            ));
            #endregion

            bundles.Add(new ScriptBundle("~/bundles/demo").Include(
                "~/assets/demo/demo.js",
                "~/assets/demo/demo-switcher.js",
                "~/assets/demo/demo-index.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/angular-datatable").Include(
                "~/Scripts/angular-datatables.js",
                "~/Scripts/angular-datatables.util.js",
                "~/Scripts/angular-datatables.options.js",
                "~/Scripts/angular-datatables.instances.js",
                "~/Scripts/angular-datatables.factory.js",
                "~/Scripts/angular-datatables.renderer.js",
                "~/Scripts/angular-datatables.directive.js",
                "~/Scripts/plugins/bootstrap/angular-datatables.bootstrap.options.js",
                "~/Scripts/plugins/bootstrap/angular-datatables.bootstrap.colvis.js",
                "~/Scripts/plugins/bootstrap/angular-datatables.bootstrap.tabletools.js",
                "~/Scripts/plugins/bootstrap/angular-datatables.bootstrap.js",
                "~/Scripts/plugins/colvis/angular-datatables.colvis.js",
                "~/Scripts/plugins/colreorder/angular-datatables.colreorder.js",
                "~/Scripts/plugins/tabletools/angular-datatables.tabletools.js",
                "~/Scripts/plugins/scroller/angular-datatables.scroller.js",
                "~/Scripts/plugins/columnfilter/angular-datatables.columnfilter.js",
                "~/Scripts/plugins/light-columnfilter/angular-datatables.light-columnfilter.js",
                "~/Scripts/plugins/fixedcolumns/angular-datatables.fixedcolumns.js",
                "~/Scripts/plugins/fixedheader/angular-datatables.fixedheader.js",
                "~/Scripts/plugins/buttons/angular-datatables.buttons.js",
                "~/Scripts/plugins/select/angular-datatables.select.js"
            ));

            #region App Angular
            //App
            bundles.Add(new ScriptBundle("~/bundles/App").Include(
                "~/Angular/App.js",
                "~/Angular/Config.js",
                "~/Angular/Util.js",
                "~/Angular/Routes.js",
                "~/assets/js/application.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/Controllers").IncludeDirectory(
                "~/Angular/Controllers", "*.js", true
            ));

            bundles.Add(new ScriptBundle("~/bundles/Services").IncludeDirectory(
                "~/Angular/Services", "*.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/Directives").IncludeDirectory(
                "~/Angular/Directives", "*.js"
            ));
            #endregion
        }
    }
}