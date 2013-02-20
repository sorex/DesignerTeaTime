using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using J.Entities;

namespace J.MainWeb.Controllers
{
	public class DesignController : Controller
	{
		//
		// GET: /Design/

		public ActionResult Index()
		{
			using(DBEntities db = new DBEntities())
			{
				ViewBag.MaterialList = JsonConvert.SerializeObject((from m in db.Materials
									   select new { GUID = m.GUID, Name = m.Name }).ToList());
			}
			return View();
		}

		public ActionResult IndexTest()
		{
			return View();
		}


		[HttpPost]
		public ActionResult CreateDesignWorks()
		{
			if (Request.IsAjaxRequest())
			{

			}
			return View();
		}
	}
}
