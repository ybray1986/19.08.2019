using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext db = null;
        private readonly DbSet<T> table = null;
        public Repository()
        {
            db = new DBContext();
            table = db.Set<T>();
        }
        public Repository(string connectionStringParam) { db = new DBContext(connectionStringParam); }
        public Repository(DbContext dbParam)
        {
            db = dbParam;
        }
        public void Add(T model)
        {
            table.Add(model);
        }

        public void Delete(int id)
        {
            T model = table.Find(id);
            table.Remove(model);
        }

        public void Update(T model)
        {
            db.Entry(model).State = EntityState.Modified;
        }

        public T Get(int id)
        {
            return table.Find(id);
        }

        public IEnumerable<T> List()
        {
            return table.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}