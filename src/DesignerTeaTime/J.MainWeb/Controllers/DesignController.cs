﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace J.MainWeb.Controllers
{
	public class DesignController : Controller
	{
		//
		// GET: /Design/

		public ActionResult Index()
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
