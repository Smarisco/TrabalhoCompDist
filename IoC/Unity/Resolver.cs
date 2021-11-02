using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Unity;

namespace InversaoDeControle.Unity
{
    public class Resolver : IDependencyResolver
    {
        protected IUnityContainer container;

        //teste merge

        public Resolver(IUnityContainer container)
        {
            if (container == null)
                throw new ArgumentNullException("container");

            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return container.Resolve(serviceType);
            }
            catch (ResolutionFailedException ex)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        public void Dispose()
        {
            container.Dispose();
        }

        public IDependencyScope BeginScope()
        {
            throw new NotImplementedException();
        }
    }
}
