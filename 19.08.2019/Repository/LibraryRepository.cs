using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19._08._2019.Repository
{
    public class LibraryRepository :IRepository<Library>
    {
        public readonly DbContext db;
        public LibraryRepository()
        {
            db = new DbContext();
        }

        public void Add(Library model)
        {
            db.Library.Add(model);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Library.Remove(Get(id));
        }

        public void Edit(Library model)
        {
            var oldBook = db.Library.Where(x => x.ID == model.ID).FirstOrDefault();
            oldBook.UserID = model.UserID;
            oldBook.BookID = model.BookID;
            oldBook.CreatedDate = model.CreatedDate;
            oldBook.Deadline = model.Deadline;
            oldBook.ReturnedDate = model.ReturnedDate;
            db.SaveChanges();
        }

        public Library Get(int id)
        {
            return db.Library.Where(i => i.ID == id).FirstOrDefault();
        }

        public IEnumerable<Library> List()
        {
            return db.Library.ToList();
        }
    }
}