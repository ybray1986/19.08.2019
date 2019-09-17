using _19._08._2019;
using _19._08._2019.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWork
{
    interface IUnitOfWork: IDisposable
    {
        IRepository<Authors> Authors { get; set; }
        IRepository<Books> Books { get; set; }
        IRepository<Genre> Genre { get; set; }
        IRepository<Library> Library { get; set; }
        IRepository<Users> Users { get; set; }
        void Save();
    }
}
