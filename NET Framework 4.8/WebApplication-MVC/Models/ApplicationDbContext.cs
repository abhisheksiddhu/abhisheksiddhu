using System.Data.Entity;

namespace WebApplication_MVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=Default")
        {
            Database.Log = message => System.Diagnostics.Debug.WriteLine(message);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publication> Publications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().Property(x => x.Title).IsRequired();
        }
    }
}