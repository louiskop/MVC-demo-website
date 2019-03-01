using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PortfolioWebsite
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);

			routes.MapRoute(
				"Contact Page",
				"{controller}/{action}/",
				new {controller = "Home", action="Contact"}


				);

			routes.MapRoute(
				name: "Projects and skills",
				url: "{controller}/{action}/",
				defaults: new { controller = "catagories", action = "ProjectsAndSkills" }
				);

			routes.MapRoute(
				"Education and Qualifications",
				"{controller}/{action}/",
				new {controller = "catagories", action = "EducationAndQualifications" }
			);

			routes.MapRoute(
					"Follow me",
					"{controller}/{action}/",
					new {controller= "Home", action="Follow"}
					);





			
		}
	}
}
