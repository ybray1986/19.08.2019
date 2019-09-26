using DataLayer.Entities;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Repository<Authors> AuthorUoWRepository { get; }
        Repository<Books> BookUoWRepository { get; }
        Repository<Genre> GenreUoWRepository { get; }
        Repository<Library> LibraryUoWRepository { get; }
        Repository<Users> UserUoWRepository { get; }
        void Save();
    }
}
