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
            }

            return View(books);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Books book)
        {
            using (Model1 db = new Model1())
            {
                db.Books.Add(book);
                db.SaveChanges();

            }
            return RedirectToActionPermanent("Index", "Book");
        }
    }
}