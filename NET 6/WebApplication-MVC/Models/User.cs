using System.ComponentModel.DataAnnotations;

namespace WebApplication_MVC.Models
{
    public record User
    {        
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required,EmailAddress]        
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? UserName { get; set; }
        public IFormFile? Photo { get; set; }
    }
}
