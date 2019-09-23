using AutoMapper;
using DataLayer.UnitOfWork;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.DataTransferObjects
{
    public class AuthorsDTO: BusinessObjectBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AuthorsDTO(IMapper mapper, UnitOfWorkFactory unitOfWorkFactory)
            : base(mapper, unitOfWorkFactory)
        {}
        //Add Methods to work with (CRUD)
        public AuthorsDTO GetAuthorsListById(int? id)
        {
            AuthorsDTO authors;
            using (var unitOfWork = unitOfWorkFactory.Create())
            {
                authors = unitOfWork.AuthorUoWRepository.List().Where(a => a.Id == id).Select(auth => mapper.Map<AuthorsDTO>(auth)).FirstOrDefault();
            }
            //BusinessObjectBase businessObjectBase = new BusinessObjectBase();
            return authors;
        }
        public List<AuthorsDTO> GetAll()
        {
            using (var unitOfWork = unitOfWorkFactory.Create())
            {
                var authors = unitOfWork.AuthorUoWRepository.List();
                return authors as List<AuthorsDTO>;
            }
            
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
