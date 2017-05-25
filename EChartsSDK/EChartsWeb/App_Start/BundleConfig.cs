using System.Web;
using System.Web.Optimization;

namespace EChartsWeb
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

            
            //菜单管理
            bundles.Add(new ScriptBundle("~/bundles/nav").Include(
                     "~/Scripts/examples-nav.js",                     
                     "~/Scripts/chart-list.js",
                      "~/Scripts/config.js",
                      "~/Scripts/place/place.js",
                         "~/Scripts/waypoint.js",
                          "~/Scripts/jquery.lazyload.min.js"

                   ));
       
           

            //绘图插件
            bundles.Add(new ScriptBundle("~/bundles/echarts").Include(
                      "~/Scripts/plugins/echarts/echarts-all-3.js"
                    ));

           //zrender
            bundles.Add(new ScriptBundle("~/bundles/zrender").Include(
                      "~/Scripts/plugins/zrender/zrender.js"));

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

           


        }
    }
}
