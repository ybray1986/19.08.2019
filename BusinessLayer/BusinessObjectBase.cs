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
        protected IMapper mapper;
        protected UnitOfWorkFactory unitOfWorkFactory;
        public BusinessObjectBase(IMapper mapper, UnitOfWorkFactory unitOfWorkFactory)
        {
            this.mapper = mapper;
            this.unitOfWorkFactory = unitOfWorkFactory;
        }
        public BusinessObjectBase()
        {
        }
    }
}
