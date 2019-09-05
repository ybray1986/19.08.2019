using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19._08._2019
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            List<Books> books;
            using (DbContext db = new DbContext())
            {
                books = db.Books.ToList();
                
            }
            return View(books);
        }

        public ActionResult CreateEdit()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateEdit(int? id)
        {
            using (DbContext db = new DbContext())
            {
                ViewBag.AuthID = new SelectList(db.Authors.Select(i => i.Id).ToList());
            }
            if (id != null)
            {
                Books books;
                using (DbContext db = new DbContext())
                {
                    books = db.Books.Where(x => x.Id == id).FirstOrDefault();
                }
                return View(books);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult CreateEdit(Books books)
        {
            if (books.Id == 0)
            {
                using (DbContext db = new DbContext())
                {
                    db.Books.Add(books);
                    db.SaveChanges();
                    return Redirect("Index");
                }
            }
            else
            {
                using (DbContext db = new DbContext())
                {
                    var oldBook = db.Books.Where(x => x.Id == books.Id).FirstOrDefault();
                    oldBook.AuthorId = books.AuthorId;
                    oldBook.Title = books.Title;
                    oldBook.Pages = books.Pages;
                    oldBook.Price = books.Price;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
        }

        public ActionResult Delete(int id)
        {
            using (DbContext db = new DbContext())
            {
                db.Books.Remove(db.Books.Find(id));
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}