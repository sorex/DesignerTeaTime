using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace J.MainWeb.Areas.Admin.Controllers
{
	public class MaterialTypeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.GUID = Guid.NewGuid().ToString();
			if (!Request.IsAjaxRequest())
			{
				return View();
			}
			else
			{
				return Content("");
			}
		}

		public ActionResult Create()
		{
			return View();
		}

		public ActionResult Update()
		{
			return View();
		}

		public ActionResult Delete()
		{
			return View();
		}
	}
}
