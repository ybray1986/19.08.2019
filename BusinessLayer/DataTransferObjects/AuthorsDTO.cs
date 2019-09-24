using AutoMapper;
using DataLayer.UnitOfWork;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Ninject;

namespace BusinessLayer.DataTransferObjects
{
    public class AuthorsDTO : BusinessObjectBase
    {
        //private readonly IKernel container;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AuthorsDTO(IMapper mapper, UnitOfWorkFactory unitOfWorkFactory/*, IKernel containerParam*/)
            : base(mapper, unitOfWorkFactory)
        {
            //container = containerParam;
        }

        //Add Methods to work with (CRUD)
        public AuthorsDTO GetAuthorsListById(int? id)
        {
            AuthorsDTO authors;
            using (var unitOfWork = unitOfWorkFactory.Create())
            {
                authors = unitOfWork.AuthorUoWRepository.List().Where(a => a.Id == id).Select(auth => mapper.Map<AuthorsDTO>(auth)).FirstOrDefault();
            }
            return authors;
        }

        public List<AuthorsDTO> GetAll()
        {
            List<AuthorsDTO> authors = new List<AuthorsDTO>();
            using (var unitOfWork = unitOfWorkFactory.Create())
            {
                authors = unitOfWork.AuthorUoWRepository.List().Select(item => mapper.Map<AuthorsDTO>(item)).ToList();
            }
            return authors;

        }

        public void Delete(int id)
        {
            using (var unitOfWork = unitOfWorkFactory.Create())
            {
                unitOfWork.AuthorUoWRepository.Delete(id);
                unitOfWork.AuthorUoWRepository.Save();
            }
        }
    }
}
