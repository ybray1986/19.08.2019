//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using AutoMapper;
//using BusinessLayer.Profiles;
//using Ninject;
//using _19._08._2019.Profiles;

//namespace _19._08._2019.Infrastucture
//{
//    class NinjectDependencyResolver : IDependencyResolver
//    {
//        private IKernel kernel;
//        NinjectDependencyResolver(IKernel kernelParam)
//        {
//            kernel = kernelParam;
//            AddBindings();
//        }

//        private void AddBindings()
//        {
//            //AutoMapper
//            kernel.Bind<IMapper>().ToMethod(context =>
//            {
//                var config = new MapperConfiguration(cfg =>
//                {
//                    // Tell Automapper to use Ninject when creating value converters and resolvers
//                    cfg.ConstructServicesUsing(t => kernel.Get(t));
//                    cfg.AddProfile<BLProfile>();
//                    cfg.AddProfile<WebProfile>();
//                });
//                return config.CreateMapper();
//            }).InSingletonScope();
//        }

//        public object GetService(Type serviceType)
//        {
//            return kernel.TryGet(serviceType);
//        }

//        public IEnumerable<object> GetServices(Type serviceType)
//        {
//            return kernel.GetAll(serviceType);
//        }
//    }
//}