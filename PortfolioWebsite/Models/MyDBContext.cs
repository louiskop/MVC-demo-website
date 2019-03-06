using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PortfolioWebsite.Models
{
	public class MyDBContext : DbContext
	{
		public DbSet<ContactModel> Contacts { get; set; }

		public MyDBContext()
		{
		}

	}
}