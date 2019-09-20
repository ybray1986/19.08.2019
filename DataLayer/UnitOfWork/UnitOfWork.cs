using DataLayer.Repository;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWork
{
    public class UnitOfWork
    {
        //implement all repositories
        Repository<Authors> AuthorUoWRepository { get; set; }
        Repository<Books> BookUoWRepository { get; set; }
        Repository<Genre> GenreUoWRepository { get; set; }
        Repository<Library> LibraryUoWRepository { get; set; }
        Repository<Users> UserUoWRepository { get; set; }

    }
}
