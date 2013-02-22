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
			using (DBEntities db = new DBEntities())
			{
				var Materials = (from m in db.Materials
								 select new { GUID = m.GUID, Name = m.Name }).ToList();
				string MaterialID = Materials.FirstOrDefault().GUID;
				var MaterialColors = (from c in db.MaterialColors
									  where c.MaterialID == MaterialID
									  select new { ColorName = c.ColorName, ColorCode = c.ColorCode, IsSelected = c.IsDefault }).ToList();
				var MaterialPictures = (from p in db.MaterialPictures
										where p.MaterialID == MaterialID
										select new { p.GUID, p.Index, p.Name, p.FileName, p.Width, p.Height, p.Top, p.Left, p.UploadWidth, p.UploadHeight }).OrderBy(p => p.Index).ToList();
				ViewBag.Data = JsonConvert.SerializeObject(new { Materials, MaterialColors, MaterialPictures });
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
