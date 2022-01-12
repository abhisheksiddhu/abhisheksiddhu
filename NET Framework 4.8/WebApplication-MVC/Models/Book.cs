using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication_MVC.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public string ISBN { get; set; }
        //public DateTime LaunchDate { get; set; }

        public List<Author> Authors { get; set; }

        [NotMapped]
        public List<int> AuthorIds { get; set; }

        [ForeignKey("Publication")]
        public int PublicationId { get; set; }

        public Publication Publication { get; set; }
    }
}