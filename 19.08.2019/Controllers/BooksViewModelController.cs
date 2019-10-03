using _19._08._2019.ViewModel.Books;
using AutoMapper;
using BusinessLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19._08._2019.Controllers
{
    public class BooksViewModelController : Controller
    {
        private IMapper mapper;
        public BooksViewModelController(IMapper mapperParam)
        {
            mapper = mapperParam;
        }
        // GET: BooksViewModel
        public ActionResult Index()
        {
            var booksDTO = mapper.ServiceCtor.Invoke(typeof(BooksDTO));
            var booksViewModelList = (booksDTO as BooksDTO).GetAll().Select(m => mapper.Map<BooksViewModel>(m)).ToList();
            return View(booksViewModelList);
        }

        // GET: BooksViewModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BooksViewModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksViewModel/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksViewModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BooksViewModel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksViewModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BooksViewModel/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
