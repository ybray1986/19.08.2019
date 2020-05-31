using _19._08._2019.ViewModel.Authors;
using AutoMapper;
using BusinessLayer.DataTransferObjects;
using BusinessLayer.Profiles;
using DataLayer.Entities;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19._08._2019.Infrastucture
{
    public class AutoMapperModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToMethod(AutoMapper).InSingletonScope();
        }

        private IMapper AutoMapper(Ninject.Activation.IContext context)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.ConstructServicesUsing(type => context.Kernel.Get(type));
                cfg.AddProfile<AutoMapperProfile>();

            });
            //Mapper.AssertConfigurationIsValid(); // optional
            return Mapper.Instance;
        }
    }
}