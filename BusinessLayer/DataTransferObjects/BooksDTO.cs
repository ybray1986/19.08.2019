using AutoMapper;
using DataLayer.Entities;
using DataLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.DataTransferObjects
{
    public class BooksDTO
    {
        private IMapper mapper;

        private int authorId;
        private int genreId;
        public int Id { get; set; }
        public string AuthorFullName { get; set; }
        public string Title { get; set; }
        public int? Pages { get; set; }
        public int? Price { get; set; }
        public string GenreName { get; set; }

        public BooksDTO() { }
        public BooksDTO(IMapper mapperParam)
        {
            mapper = mapperParam;
        }
        public BooksDTO GetBooksListById(int? id)
        {
            BooksDTO books;
            using (var unitOfWork = UnitOfWorkFactory.Create())
            {
                books = unitOfWork.BookUoWRepository.List().Where(a => a.Id == id).Select(book => mapper.Map<BooksDTO>(book)).FirstOrDefault();
            }
            return books;
        }

        public List<BooksDTO> GetAll()
        {
            List<BooksDTO> books = new List<BooksDTO>();
            using (var unitOfWork = UnitOfWorkFactory.Create())
            {
                books = unitOfWork.BookUoWRepository.List().Select(item => mapper.Map<BooksDTO>(item)).ToList();
            }
            return books;

        }

        public void Delete(int id)
        {
            using (var unitOfWork = UnitOfWorkFactory.Create())
            {
                unitOfWork.BookUoWRepository.Delete(id);
                unitOfWork.BookUoWRepository.Save();
            }
        }

        public void Save()
        {
            using (var unitOfWork = UnitOfWorkFactory.Create())
            {
                if (Id != 0)
                    Update(unitOfWork);
                else
                    Add(unitOfWork);
            }
        }

        private void Add(IUnitOfWork unitOfWork)
        {
            var book = mapper.Map<Books>(this);
            unitOfWork.BookUoWRepository.Add(book);
            unitOfWork.Save();
        }

        private void Update(IUnitOfWork unitOfWork)
        {
            throw new NotImplementedException();
        }
    }
}
