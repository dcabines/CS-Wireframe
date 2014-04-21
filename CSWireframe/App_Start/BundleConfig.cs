using System;
using System.Web.Optimization;

namespace CSWireframe {
    public class BundleConfig {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/Scripts/base").Include(
                        "~/Scripts/libs/jquery-2.1.0.js",
                        "~/Scripts/libs/bootstrap.js",
                        "~/Scripts/libs/knockout-3.1.0.js",

                        "~/Scripts/app.js",

                        "~/Scripts/models/FBPage.js",
                        "~/Scripts/models/RegistrationInfo.js",
                        "~/Scripts/models/BasicInfo.js",
                        "~/Scripts/models/ViewModel.js"));

            bundles.Add(new StyleBundle("~/bundles/Styles/base").Include(
                        "~/Styles/bootstrap.css",
                        "~/Styles/style.css"));
        }
    }
}