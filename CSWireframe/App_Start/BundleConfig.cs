using System;
using System.Web.Optimization;

namespace CSWireframe {
    public class BundleConfig {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/Scripts/base").Include(
                        "~/Scripts/jquery-2.1.0.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/knockout-3.1.0.js"));

            bundles.Add(new StyleBundle("~/bundles/Styles/base").Include(
                        "~/Styles/bootstrap.css",
                        "~/Styles/style.css"));
        }
    }
}