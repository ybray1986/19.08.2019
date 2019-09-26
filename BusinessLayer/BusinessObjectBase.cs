﻿using System;
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
        //UnitOfWorkFactory
        //To bind Mapping and UnitOfWork(each repository to mapping)
        protected IMapper mapper;
        protected UnitOfWorkFactory unitOfWorkFactory;
        public BusinessObjectBase(IMapper mapper, UnitOfWorkFactory unitOfWorkFactory)
        {
            this.mapper = mapper;
            this.unitOfWorkFactory = unitOfWorkFactory;
        }
    }
}
