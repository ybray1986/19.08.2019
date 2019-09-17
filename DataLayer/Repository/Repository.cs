using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _19._08._2019.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Model1 db;
        private readonly DbSet<T> table = null;
        public Repository()
        {
            db = new Model1();
            table = db.Set<T>();
        }
        public Repository(string connectionStringParam) { db = new Model1(connectionStringParam); }
        public Repository(Model1 dbParam)
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