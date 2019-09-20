using DataLayer.Entities;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        Repository<Authors> AuthorUoWRepository { get; set; }
        Repository<Books> BookUoWRepository { get; set; }
        Repository<Genre> GenreUoWRepository { get; set; }
        Repository<Library> LibraryUoWRepository { get; set; }
        Repository<Users> UserUoWRepository { get; set; }
    }
}
