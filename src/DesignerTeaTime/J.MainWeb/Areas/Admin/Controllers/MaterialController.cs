using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using J.Entities;

namespace J.MainWeb.Areas.Admin.Controllers
{
    public class MaterialController : Controller
    {
        //
        // GET: /Admin/Material/

        public ActionResult Index()
        {
			using (DBEntities db = new DBEntities())
			{
				//ViewBag.MaterialTypeSelectList 
				ViewBag.MaterialTypeSelectList = new SelectList(db.MaterialTypes.OrderBy(p => p.Index).ToList(), "GUID", "Name");

			}
			
            return View();
        }

    }
}
