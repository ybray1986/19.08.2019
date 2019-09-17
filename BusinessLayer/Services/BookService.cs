using BusinessLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    class BookService : IRepositoryService<BooksDTO>
    {
        public void Add(BooksDTO model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BooksDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BooksDTO> List()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(BooksDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
