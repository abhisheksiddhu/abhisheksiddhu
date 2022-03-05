using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVC.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required, MinLength(5)]
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}