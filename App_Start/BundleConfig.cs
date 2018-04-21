﻿using System.Web;
using System.Web.Optimization;

namespace RealEstate
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Resources/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Resources/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Resources/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Resources/Scripts/bootstrap.js",
                      "~/Resources/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Resources/CSS/bootstrap.css",
                      "~/Resources/CSS/site.css"));

            bundles.Add(new StyleBundle("~/Content/Home").Include(
                      "~/Resources/CSS/Home/Banner.css"));

            bundles.Add(new StyleBundle("~/Content/Icon").Include(
                      "~/Resources/Icons/css/fontawesome-all.css"));
        }
    }
}
