using HiwDI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HiwDI.Web.Mvc
{
    public class HiwDIResolver : IDependencyResolver
    {
        internal static HiwDIContainer _container;
        public HiwDIResolver(HiwDIContainer container)
        {
            _container = container;
            container.Register<IControllerFactory, DefaultControllerFactory>();
            container.Register<IControllerActivator, ControllerActivator>();
            container.Register<IController, Controller>();
            container.Register<ITempDataProviderFactory, ITempDataProviderFactory>();
        }
        public object GetService(Type serviceType)
        {
            var result = _container.Inject(serviceType);
            return result;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            //TODO: Becasue this project is a simple implement of DI.
            // It doen't support `Multi service models`
            var result = new List<object>();

            var injectedItem = _container.Inject(serviceType);
            result.Add(injectedItem);

            return result;
        }
    }
}
