﻿using System.Web;
using System.Web.Optimization;

namespace J.MainWeb
{
	public class BundleConfig
	{
		// 有关 Bundling 的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=254725
		public static void RegisterBundles(BundleCollection bundles)
		{

			#region CSS
			#region Site CSS
			bundles.Add(new StyleBundle("~/Static/site/css/files").Include(
						"~/Static/site/css/reset.css",
						"~/Static/site/css/site.css"));
			#endregion

			#region jquery ui CSS
			bundles.Add(new StyleBundle("~/Static/jquery-ui/css/files").Include(
						"~/Static/jquery-ui/css/jquery-ui*"));
			#endregion

			#region uploadify CSS
			bundles.Add(new StyleBundle("~/Static/uploadify/css").Include(
			"~/Static/uploadify/uploadify.css"));
			#endregion
			#endregion

			#region JS
			#region Modernizr
			// 使用 Modernizr 的开发版本进行开发和了解信息。然后，当你做好
			// 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
			bundles.Add(new ScriptBundle("~/Static/modernizr/files").Include(
						"~/Static/modernizr/modernizr-*"));
			#endregion

			#region jquery
			bundles.Add(new ScriptBundle("~/Static/jquery/files").Include(
						"~/Static/jquery/jquery-{version}.js",
						"~/Static/jquery/jquery-migrate-{version}.js"));
			#endregion

			#region jquery ui
			bundles.Add(new ScriptBundle("~/Static/jquery-ui/js/files").Include(
						"~/Static/jquery-ui/js/jquery-ui-{version}.js",
						"~/Static/jquery-ui/js/i18n/jquery.ui.datepicker-zh-CN.js"));
			#endregion

			#region jquery validate
			bundles.Add(new ScriptBundle("~/Static/jquery.validate/files").Include(
						"~/Static/jquery.validate/jquery.validate*"));
			#endregion

			#region jquery layout
			bundles.Add(new ScriptBundle("~/Static/jquery.layout/files").Include(
						"~/Static/jquery.layout/jquery.layout*"));
			#endregion

			#region json2
			bundles.Add(new ScriptBundle("~/Static/json2/files").Include(
			"~/Static/json2/json2*"));
			#endregion

			#region uploadify
			bundles.Add(new ScriptBundle("~/Static/uploadify/js").Include(
						"~/Static/uploadify/jquery.uploadify-{version}.js"));
			#endregion

			#region extendjs
			bundles.Add(new ScriptBundle("~/Static/extendjs/files").Include(
						"~/Static/extendjs/extendjs*"));
			#endregion
			#endregion

		}
	}
}