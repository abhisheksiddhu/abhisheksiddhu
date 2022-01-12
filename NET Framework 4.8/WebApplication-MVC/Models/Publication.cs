using System.Collections.Generic;

namespace WebApplication_MVC.Models
{
    public class Publication
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }

        public List<Book> Books { get; set; }
    }
}