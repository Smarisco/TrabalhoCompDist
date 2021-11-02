using System;
using System.Collections.Generic;
using Unity;

namespace InversaoDeControle.Unity
{
    class Resolver
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

        //public IDependencyScope BeginScope()
        //{
        //    var child = container.CreateChildContainer();
        //    return new Resolver(child);
        //}

        public void Dispose()
        {
            container.Dispose();
        }
    }
}
