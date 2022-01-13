using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_MVC.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string PublicationName { get; set; }
        public string Authors { get; set; }
    }
}