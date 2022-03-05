using System.Collections.Generic;

namespace WebApplication_API.Models
{
	public class Author
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<Book> Books { get; set; }
	}
}