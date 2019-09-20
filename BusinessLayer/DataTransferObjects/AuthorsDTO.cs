using AutoMapper;
using DataLayer.UnitOfWork;

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

            using (var unitOfWork = UnitOfWorkFactory.Create())
            {
                authors = unitOfWork.AuthorUoWRepository.GetAll().Where(a => a.Id == id).Select(item => mapper.Map<AuthorBO>(item)).FirstOrDefault();
            }
            return authors;
        }
    }
}
