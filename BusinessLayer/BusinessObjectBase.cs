using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataLayer.UnitOfWork;

namespace BusinessLayer
{
    public abstract class BusinessObjectBase
    {
        //IMapper
        //UnitOfWork
        //To bind Mapping and UnitOfWork
        IMapper mapper;
        UnitOfWork unitOfWork;
        public BusinessObjectBase(IMapper mapper, UnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
    }
}
