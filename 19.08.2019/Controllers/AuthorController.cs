using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using BusinessLayer.DataTransferObjects;

namespace _19._08._2019
{
    public class AuthorController : Controller
    {
        IMapper mapper;
        AuthorController(IMapper mapperParam)
        {
            mapper = mapperParam;
        }
        // GET: Author
        public ActionResult Index()
        {
            List<Authors> authors;
            using (DbContext db = new DbContext())
            {
                authors = db.Authors.ToList();
            }

            return View(authors);
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
                Authors author;
                using (DbContext db = new DbContext())
                {
                    author = db.Authors.Where(x => x.Id == id).FirstOrDefault();
                }
                return View(author);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult CreateEdit(Authors author)
        {
            if (author.Id == 0)
            {
                using (DbContext db = new DbContext())
                {
                    db.Authors.Add(author);
                    db.SaveChanges();
                    return Redirect("Index");
                }
            }
            else
            {
                using (DbContext db = new DbContext())
                {
                    var oldAuthor = db.Authors.Where(x => x.Id == author.Id).FirstOrDefault();
                    oldAuthor.FirstName = author.FirstName;
                    oldAuthor.LastName = author.LastName;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
        }
        public ActionResult Delete (int id)
        {
            var author = DependencyResolver.Current.GetService<AuthorsDTO>
            var model = mapper.Map<>
        }
    }
}