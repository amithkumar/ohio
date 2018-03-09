/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.Web.Optimization;

namespace Ohio.DeferredCompensation
{
    /// <summary>
    /// The Bundles Configuration.
    /// </summary>
    ///
    /// <author>TCSCODER</author>
    /// <version>1.0</version>
    /// <copyright>Copyright (c) 2018, TopCoder, Inc. All rights reserved.</copyright>
    public class BundleConfig
    {
        /// <summary>
        /// Registers the bundles.
        /// </summary>
        /// <param name="bundles">The bundles.</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862

            bundles.Add(new StyleBundle("~/Content/common").Include(
                      "~/bower_components/jquery-ui/themes/base/jquery-ui.css",
                      "~/bower_components/malihu-custom-scrollbar-plugin/jquery.mCustomScrollbar.css",
                      "~/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/css/style.css",
                      "~/bower_components/slick-carousel/slick/slick.css",
                      "~/bower_components/slick-carousel/slick/slick-theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/third-party-common-js").Include(
                        "~/bower_components/jquery/dist/jquery.js",
                        "~/bower_components/jquery-ui/jquery-ui.js",
                        "~/bower_components/bootstrap/dist/js/bootstrap.js",
                        "~/bower_components/d3/d3.js",
                        "~/bower_components/slick-carousel/slick/slick.min.js",
                        "~/bower_components/malihu-custom-scrollbar-plugin/jquery.mCustomScrollbar.js"));

            bundles.Add(new ScriptBundle("~/bundles/third-party-forms-js").Include(
                        "~/bower_components/jquery-validation/dist/jquery.validate.js",
                        "~/bower_components/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js",
                        "~/bower_components/jquery-form/src/jquery.form.js"));

            bundles.Add(new ScriptBundle("~/bundles/site-js").Include("~/Scripts/script.js"));
        }
    }
}
