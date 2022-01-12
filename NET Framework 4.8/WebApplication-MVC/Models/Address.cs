using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication_MVC.Models
{
    [ComplexType]
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
    }
}