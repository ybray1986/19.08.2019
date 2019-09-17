using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._08._2019.Repository
{
    public interface IRepository<T> where T: class
    {
        void Add(T model);
        IEnumerable<T> List();
        T Get(int id);
        void Save();
        void Update(T model);
        void Delete(int id);
    }
}
