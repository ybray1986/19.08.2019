using AutoMapper;
using DataLayer.UnitOfWork;

namespace BusinessLayer.DataTransferObjects
{
    public class AuthorsDTO: BusinessObjectBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AuthorsDTO(IMapper mapper, UnitOfWork unitOfWork)
            : base(mapper, unitOfWork)
        {}
        //Add Methods to work with (CRUD)

    }
}
