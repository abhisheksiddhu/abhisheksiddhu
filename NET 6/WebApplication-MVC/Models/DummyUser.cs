using Bogus;

using System.ComponentModel.DataAnnotations;

using static Bogus.DataSets.Name;

namespace WebApplication_MVC.Models;

public class DummyUser
{
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }
    [Required] public string FullName { get; set; }
    [Required] public string Password { get; set; }
    [Required] public string Phone { get; set; }
    [Required] public string Avatar { get; set; }
    [Required] public DateTime DateOfBirth { get; set; }
    [Required] public string Email { get; set; }
    [Required] public string UserName { get; set; }


    [Required] public Gender Gender { get; set; }
    [Required] public int[] City { get; set; } = Array.Empty<int>();
    public bool IsEmailConfirmed { get; set; }
    public int Counter { get; set; } = 0;
    [RegularExpression(@"^(0|-?\d{0,6}(\.\d{0,2})?)$")]
    public decimal Price { get; set; } = 0;

    public static Dictionary<Gender, string> Genders { get; } = new()
    {
        [Gender.Male] = "Male",
        [Gender.Female] = "Female"
    };

    public static Dictionary<int, string> Cities { get; } = new()
    {
        [1] = "City 1",
        [2] = "City 2",
        [3] = "City 3",
        [4] = "City 4",
        [5] = "City 5",
        [6] = "City 6",
    };


    public static Faker<DummyUser> Faker { get; } = new Faker<DummyUser>()
            .RuleFor(b => b.Email, f => f.Person.Email)
            .RuleFor(b => b.FirstName, f => f.Person.FirstName)
            .RuleFor(b => b.LastName, f => f.Person.LastName)
            .RuleFor(u => u.FullName, (f, u) => u.FirstName + " " + u.LastName)
            .RuleFor(b => b.Password, f => f.Internet.Password())
            .RuleFor(b => b.Phone, f => f.Person.Phone)
            .RuleFor(u => u.Avatar, f => f.Internet.Avatar())
            .RuleFor(b => b.DateOfBirth, f => f.Person.DateOfBirth)
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
            .RuleFor(u => u.UserName, (f, u) => f.Internet.UserName(u.FirstName, u.LastName))
        ;
}

public static class Global
{
    public static List<DummyUser> Data { get; } = DummyUser.Faker.Generate(10);
}