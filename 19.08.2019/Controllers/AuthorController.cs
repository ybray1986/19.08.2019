using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _19._08._2019.ViewModel.Authors;
using AutoMapper;
using BusinessLayer.DataTransferObjects;
using Ninject.Activation;
using Ninject.Web.Mvc;
//using _19._08._2019.Infrastucture;

namespace _19._08._2019
{
    public class AuthorController : Controller
    {
        IMapper mapper;
        public AuthorController(IMapper mapperParam)
        {
            mapper = mapperParam;
        }
        // GET: Author
        public ActionResult Index()
        {
            var authorDTO = DependencyResolver.Current.GetService<AuthorsDTO>();
            var authorList = authorDTO.GetAll();
            var model = authorList.Select(m => mapper.Map<AuthorsViewModel>(m)).ToList();
            return View(model);
        }

        public ActionResult CreateEdit()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateEdit(int? id)
        {
            var authorDTO = DependencyResolver.Current.GetService<AuthorsDTO>();
            var model = mapper.Map<AuthorsViewModel>(authorDTO);
            if (id != null)
            {
                var authorDTOList = authorDTO.GetAuthorsListById(id);
                model = mapper.Map<AuthorsViewModel>(authorDTOList);
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult CreateEdit(AuthorsViewModel authorParam)
        {
            var authorDTO = mapper.Map<AuthorsDTO>(authorParam);
            if (ModelState.IsValid)
            {
                authorDTO.Save();
                return RedirectToAction("Index");
            }
            else return View(authorParam);
        }
        public ActionResult Delete (int id)
        {
            var authorDTO = DependencyResolver.Current.GetService<AuthorsDTO>();
            authorDTO.Delete(id);
            return RedirectToAction("Index");
        }
    }
}