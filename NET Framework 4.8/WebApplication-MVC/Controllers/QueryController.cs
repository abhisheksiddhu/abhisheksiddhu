using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class QueryController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: Query
        public async Task<ActionResult> Index(int id = 0)
        {
            var books = db.Books.Include(b => b.Publication).Include(b => b.Authors);

            IQueryable<Book> query = books;

            switch (id)
            {
                case 1:
                    {
                        query = query.Where(book => book.Title.StartsWith("Book"));
                        //query = query.Where(book => book.Title.StartsWith("Book") || book.Title.EndsWith("1"));
                        //query = query.Where(book => book.Title.StartsWith("Book") && book.Title.EndsWith("1"));

                        //query = query.Where(book => book.Title.StartsWith("Book"));
                        //query = query.Where(book => book.Title.EndsWith("1"));

                        //query = query
                        //    .Where(book => book.Title.StartsWith("Book"))
                        //    .Where(book => book.Title.EndsWith("1"));

                        break;
                    }
                case 2:
                    {
                        //query = query.Where(book => book.Publication.Name.StartsWith("Publication"));
                        query = query.Where(book
                            => book.Authors.Any(author
                            => author.Name.StartsWith("Non")
                            ));
                        break;
                    }
                case 3:
                    {
                        query = query.OrderBy(book => book.Publication.Name).Skip(3).Take(5);
                        break;
                    }
            }

            // Deferred Execution
            List<Book> result = await query.ToListAsync();

            // Data Projection
            List<BookViewModel> model = result.Select(book => new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                ISBN = book.ISBN,
                PublicationName = book.Publication.Name,
                Authors = string.Join(", ", book.Authors.Select(author => author.Name))
            }).ToList();

            BookViewModel viewModel = model.First(book => book.Title.StartsWith("Book"));
            BookViewModel viewModel1 = model.Single(book => book.Title.StartsWith("Book"));
            return View(model);
        }
    }
}