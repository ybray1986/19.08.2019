using _19._08._2019.Profiles;
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
                cfg.ConstructServicesUsing(type => context.Kernel.Get(type)); // optional, but getting errors

                cfg.CreateMap<Authors, AuthorsDTO>() // optional: .ForMember(t=> t.Id, to => to.Ignore())
                .ConstructUsing(item => DependencyResolver.Current.GetService<AuthorsDTO>());

                cfg.CreateMap<AuthorsDTO, AuthorsViewModel>()
                .ConstructUsing(item => DependencyResolver.Current.GetService<AuthorsViewModel>());

                cfg.CreateMap<AuthorsViewModel, AuthorsDTO>()
                .ConstructUsing(item => DependencyResolver.Current.GetService<AuthorsDTO>());

                cfg.CreateMap<AuthorsDTO, Authors>()
                .ConstructUsing(item => DependencyResolver.Current.GetService<Authors>());
            });

            //Mapper.AssertConfigurationIsValid(); // optional
            return Mapper.Instance;
        }
    }
}