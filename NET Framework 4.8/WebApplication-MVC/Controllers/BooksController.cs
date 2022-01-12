using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: Books
        public async Task<ActionResult> Index()
        {
            IQueryable<Book> books = db.Books.Include(b => b.Publication).Include(b => b.Authors);
            return View(await books.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = await db.Books.FindAsync(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            ViewBag.PublicationId = new SelectList(db.Publications, "Id", "Name");
            ViewBag.AuthorIds = new SelectList(db.Authors, "Id", "Name");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Title,ISBN,PublicationId,AuthorIds")] Book book)
        {
            if (ModelState.IsValid)
            {
                List<Author> authors = await db.Authors.Where(author => book.AuthorIds.Contains(author.Id)).ToListAsync();
                book.Authors = authors;
                db.Books.Add(book);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PublicationId = new SelectList(db.Publications, "Id", "Name", book.PublicationId);
            ViewBag.AuthorIds = new SelectList(db.Authors, "Id", "Name", book.AuthorIds);
            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = await db.Books.Include(x => x.Authors).FirstAsync(x => x.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            book.AuthorIds = book.Authors.Select(author => author.Id).ToList();
            ViewBag.PublicationId = new SelectList(db.Publications, "Id", "Name", book.PublicationId);
            ViewBag.AuthorIds = new SelectList(db.Authors, "Id", "Name", book.AuthorIds);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Title,ISBN,PublicationId,AuthorIds")] Book book)
        {
            if (ModelState.IsValid)
            {
                List<Author> authors = await db.Authors.Where(author => book.AuthorIds.Contains(author.Id)).ToListAsync();
                db.Entry(book).State = EntityState.Modified;
                await db.Entry(book).Collection(x => x.Authors).LoadAsync();
                book.Authors = authors;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PublicationId = new SelectList(db.Publications, "Id", "Name", book.PublicationId);
            ViewBag.AuthorIds = new SelectList(db.Authors, "Id", "Name", book.AuthorIds);
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = await db.Books.FindAsync(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Book book = await db.Books.FindAsync(id);
            db.Books.Remove(book);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
