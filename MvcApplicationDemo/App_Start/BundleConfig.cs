﻿using System.Web;
using System.Web.Optimization;

namespace MvcApplicationDemo
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs").Include(
                "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include("~/Content/Site.css",
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap-responsive.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/customjs").Include(
           "~/Scripts/CustomScript.js"));

        }
    }
}