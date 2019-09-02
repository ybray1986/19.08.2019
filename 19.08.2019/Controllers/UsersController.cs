using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19._08._2019.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            List<Users> user = new List<Users>();
            using (Model1 db = new Model1())
            {
                user = db.Users.ToList();
            }
            return View(user);
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
                Users users;
                using (Model1 db = new Model1())
                {
                    users = db.Users.Where(x => x.ID == id).FirstOrDefault();
                }
                return View(users);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult CreateEdit(Users user)
        {
            if (user.ID == 0)
            {
                using (Model1 db = new Model1())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return Redirect("Index");
                }
            }
            else
            {
                using (Model1 db = new Model1())
                {
                    var oldUser = db.Users.Where(x => x.ID == user.ID).FirstOrDefault();
                    oldUser.FIO = user.FIO;
                    oldUser.Email = user.Email;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
        }
    }
}