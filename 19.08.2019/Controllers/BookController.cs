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
            using (Model1 db = new Model1())
            {
                books = db.Books.ToList();
                ViewBag.AuthID = db.Authors.ToList();
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
            if (id != null)
            {
                Books books;
                using (Model1 db = new Model1())
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
                using (Model1 db = new Model1())
                {
                    db.Books.Add(books);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                using (Model1 db = new Model1())
                {
                    var oldAuthor = db.Books.Where(x => x.Id == books.Id).FirstOrDefault();
                    oldAuthor.AuthorId = books.AuthorId;
                    oldAuthor.Title = books.Title;
                    oldAuthor.Pages = books.Pages;
                    oldAuthor.Price = books.Price;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
        }
    }
}