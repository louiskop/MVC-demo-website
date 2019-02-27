using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioWebsite.Controllers
{
	public class catagoriesController : Controller
	{
		// GET: catagories
		public ActionResult ProjectsAndSkills()
		{
			return View();
		}

		public ActionResult EducationAndQualifications()
		{
			return View();
		}
	}
}