using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using AutoMapper;
using BusinessLayer.DataTransferObjects;
using _19._08._2019.Infrastucture;
using _19._08._2019.ViewModel.Library;

namespace _19._08._2019.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        private IMapper mapper;

        public LibraryController(IMapper mapperParam)
        {
            mapper = mapperParam;
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
                repo.Update(library);
                return RedirectToAction("Index");
            }
        }
        //[OnlyAjaxAllowed]
        public ActionResult GetTop5Orders(int userId)
        {
            /* List<Author> ab = {find id user}
             * UserModel user = {Find User}
             * var result = new JSonResult{
             * Data = new {res = ab},
             * JsonRequestBehaviour = JsonRequestBehaviour.AllowGet
             * };
             */
            return View();
        }
        public ActionResult Delete(int id)
        {
            var LibraryDTO = DependencyResolver.Current.GetService<LibraryDTO>();
            var model = mapper.Map<LibraryViewModel>(LibraryDTO);
            var libraryBOList = LibraryDTO.GetLibraryDTOById(id);
            model = mapper.Map<LibraryViewModel>(libraryBOList);
            return RedirectToAction("Index");
        }
    }
}