using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using PortfolioWebsite.Models;

namespace PortfolioWebsite.Controllers
{
	public class ContactController : Controller
	{
		private MyDBContext context;

		public ContactController()
		{
			context= new MyDBContext();
		}


		// GET: Contact
		public ActionResult Index()
		{
			return View(context.Contacts.ToList());
		}

		public ActionResult Create()
		{
			return View(new ContactModel());
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(ContactModel model)
		{
			if (ModelState.IsValid)
			{
				context.Contacts.Add(model);
				await context.SaveChangesAsync();
				return RedirectToAction("Index");
			}

			return View(model);
		}


	}
}