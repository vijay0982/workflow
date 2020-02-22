﻿using System.Web;
using System.Web.Optimization;

namespace WorkflowProcess
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


            bundles.Add(new ScriptBundle("~/bundles/login").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.validate*"));


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

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
                "~/Scripts/dataTablesScripts/jquery.dataTables.min.js",
                "~/Scripts/dataTablesScripts/dataTables.bootstrap4.min.js"));

            bundles.Add(new StyleBundle("~/Content/dataTablescss").Include(
                "~/Content/dataTablesContent/dataTables.bootstrap.min.css",
                "~/Content/dataTablesContent/responsive.bootstrap.min.css"));
        }
    }
}
