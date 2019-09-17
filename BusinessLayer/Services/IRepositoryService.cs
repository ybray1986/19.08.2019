using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    interface IRepositoryService<T> where T: class
    {
        void Add(T model);
        IEnumerable<T> List();
        T Get(int id);
        void Save();
        void Update(T model);
        void Delete(int id);
    }
}
