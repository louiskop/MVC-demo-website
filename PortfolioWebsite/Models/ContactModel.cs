using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioWebsite.Models
{

	[Table("Contacts")]
	public class ContactModel
	{
		public int Id { get; set; }
		[StringLength(255)]
		[Required]
		public string FullName { get; set; }
		[StringLength(255),Required]
		public string Email { get; set; }
		[StringLength(1000),Required]
		public string Message { get; set; }
	}
}