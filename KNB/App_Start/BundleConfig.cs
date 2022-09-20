using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace KNB.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) //System.Web.Optimization lib
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js")); //jquery lib

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate.unobtrusive*", //jquery.unobtrussive lib
                "~/Scripts/jquery.validate*"));   //jquery.validate lib

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/respond.js")); //respond lib

            bundles.Add(new ScriptBundle("~/Content/css").Include(
                "~/Content/site.css"));                     //создание адресов
        }
    }
}