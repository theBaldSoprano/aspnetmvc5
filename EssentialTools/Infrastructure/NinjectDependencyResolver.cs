using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;
using Ninject.Web.Common;

namespace EssentialTools.Infrastructure {
    public class NinjectDependencyResolver : IDependencyResolver {

        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam) {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings() {
            //put bindings here
            kernel.Bind<IValueCalculator>().To<LinqValueCalculator>().InRequestScope();
            kernel.Bind<IDiscountHelper>()
                .To<DefaultDiscountHelper>()
                .WhenInjectedInto<LinqValueCalculator>()
                .WithPropertyValue("DiscountSize", 1M)
                .WithConstructorArgument("discountSize2", 95M);

            kernel.Bind<IDiscountHelper>()
                .To<FlexibleDiscountHelper>()
                .When((x) => DateTime.Now.Hour > 6);
        }

        public object GetService(Type serviceType) {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType) {
            return kernel.GetAll(serviceType);
        }
    }
}