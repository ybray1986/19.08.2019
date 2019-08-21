using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19._08._2019.Controllers
{
    public class AuthorController : Controller
    {
        
        // GET: Author

        public ActionResult Index()
        {
            List<Authors> list = new List<Authors>();
            using(Model1 db =new Model1())
            {
                list = db.Authors.ToList();
                //comment
            }
            return View(list);
        }
    }
}