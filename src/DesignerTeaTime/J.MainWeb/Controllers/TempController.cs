using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace J.MainWeb.Controllers
{
    public class TempController : Controller
    {
        //
        // GET: /Temp/

        public ActionResult Index()
        {
            return View();
        }


		public ActionResult JQueryUI()
		{
			return View();
		}
    }
}
