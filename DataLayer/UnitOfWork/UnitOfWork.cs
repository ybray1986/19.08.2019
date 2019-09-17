using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _19._08._2019;
using _19._08._2019.Repository;

namespace DataLayer.UnitOfWork
{
    class UnitOfWork : IUnitOfWork
    {
        LibraryContext
        public IRepository<Authors> Authors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<Books> Books { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<Genre> Genre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<Library> Library { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepository<Users> Users { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
