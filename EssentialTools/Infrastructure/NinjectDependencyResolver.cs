using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;
namespace EssentialTools.Infrastructure {
    public class NinjectDependencyResolver : IDependencyResolver {

        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam) {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings() {
            //put bindings here
            kernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            kernel.Bind<IDiscountHelper>().To<DefaultDiscountHelper>();
        }

        public object GetService(Type serviceType) {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType) {
            return kernel.GetAll(serviceType);
        }
    }
}