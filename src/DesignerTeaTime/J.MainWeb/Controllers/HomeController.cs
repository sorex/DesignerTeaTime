﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using NLog;
using System.IO;
using Newtonsoft.Json;

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

		[HttpPost]
		public ActionResult UploadFile()
		{
			HttpPostedFileBase file = Request.Files["Filedata"]; //获取单独文件的访问
			var fileGuid = Guid.NewGuid().ToString();//生成随机的guid
			try
			{
				if (file != null)
				{
					var uploadPath = Server.MapPath("~/Files") + "/Temp/" + fileGuid;
					if (!Directory.Exists(uploadPath))
					{ //判断上传的文件夹是否存在 
						Directory.CreateDirectory(uploadPath);
					}
					file.SaveAs(uploadPath + '/' + file.FileName);
					return Content(JsonConvert.SerializeObject(new { state = "success", msg = fileGuid }));
				}
				return Content(JsonConvert.SerializeObject(new { state = "error", msg = "文件不存在，请重新上传！" }));
			}
			catch (Exception e)
			{
				return Content(JsonConvert.SerializeObject(new { state = "error", msg = e.Message }));
			}
		}

	}
}
