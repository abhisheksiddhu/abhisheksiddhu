using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVC.Models
{
	public class Publication
	{
		public int Id { get; set; }
		[Required, MinLength(5, ErrorMessage = "Name should be more than 5 character")]
		public string Name { get; set; }

		public Address ShippingAddress { get; set; }
		public Address BillingAddress { get; set; }

		public List<Book> Books { get; set; }
	}
}