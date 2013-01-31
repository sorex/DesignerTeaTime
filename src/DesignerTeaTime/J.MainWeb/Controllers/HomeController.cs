using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NLog;

namespace J.MainWeb.Controllers
{
	public class HomeController : Controller
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();

		public ActionResult Index()
		{
			//logger.Log(LogLevel.Debug, "this is at MainWeb Error");
			//logger.Log(LogLevel.Debug, "this is a testB");
			return View();
		}
	}
}
