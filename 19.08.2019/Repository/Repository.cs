using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _19._08._2019.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext db;
        private readonly DbSet<T> table = null;
        public Repository()
        {
            db = new DbContext();
            table = db.Set<T>();

        }
        public Repository(DbContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }
        public void Add(T model)
        {
            table.Add(model);
        }

        public void Delete(int id)
        {
            T entity = table.Find(id);
            table.Remove(entity);
        }

        public void Edit(T model)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List()
        {
            throw new NotImplementedException();
        }
    }
}