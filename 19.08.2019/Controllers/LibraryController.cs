using _19._08._2019.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace _19._08._2019.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        private IRepository<Library> repo;

        public LibraryController(IRepository<Library> repoParam)
        {
            repo = repoParam;
        }

        public ActionResult Index()
        {
            repo.List();
            return View(repo);
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
                ViewBag.UserID = new SelectList(db.Users.Select(i => i.ID).ToList());
                ViewBag.BookID = new SelectList(db.Books.Select(i => i.Id).ToList());
            }
            if (id != null)
            {
                repo.Get(id.GetValueOrDefault());
                return View(repo);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult CreateEdit(Library library)
        {
            if (library.ID == 0)
            {
                repo.Add(library);
                return Redirect("Index");
            }
            else
            {
                repo.Edit(library);
                return RedirectToAction("Index");
            }
        }

    }
}