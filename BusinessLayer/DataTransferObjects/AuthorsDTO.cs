using AutoMapper;
using DataLayer.UnitOfWork;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Ninject;
using System;
using DataLayer.Entities;

namespace BusinessLayer.DataTransferObjects
{
    public class AuthorsDTO
    {
        private IMapper mapper;

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AuthorsDTO() { }
        public AuthorsDTO(IMapper mapperParam)
        {
            mapper = mapperParam;
        }
        public AuthorsDTO GetAuthorsListById(int? id)
        {
            AuthorsDTO authors;
            using (var unitOfWork = UnitOfWorkFactory.Create())
            {
                authors = unitOfWork.AuthorUoWRepository.List().Where(a => a.Id == id).Select(auth => mapper.Map<AuthorsDTO>(auth)).FirstOrDefault();
            }
            return authors;
        }

        public List<AuthorsDTO> GetAll()
        {
            List<AuthorsDTO> authors = new List<AuthorsDTO>();
            using (var unitOfWork = UnitOfWorkFactory.Create())
            {
                authors = unitOfWork.AuthorUoWRepository.List().Select(item => mapper.Map<AuthorsDTO>(item)).ToList();
            }
            return authors;

        }

        public void Delete(int id)
        {
            using (var unitOfWork = UnitOfWorkFactory.Create())
            {
                unitOfWork.AuthorUoWRepository.Delete(id);
                unitOfWork.AuthorUoWRepository.Save();
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
            var author = mapper.Map<Authors>(this);
            unitOfWork.AuthorUoWRepository.Add(author);
            unitOfWork.Save();
        }

        private void Update(IUnitOfWork unitOfWork)
        {
            throw new NotImplementedException();
        }
    }
}
