using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace CV.Presentation.App_Start
{
    public class UnityResolver : UnityDependencyResolver, IDependencyResolver
    {
        protected IUnityContainer container;

        public UnityResolver(IUnityContainer container) : base(container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.container = container;
        }

        public new object GetService(Type serviceType)
        {
            try
            {
                return container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        public new IEnumerable<object> GetServices(Type serviceType)
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

        public IDependencyScope BeginScope()
        {
            var child = container.CreateChildContainer();
            return new UnityResolver(child);
        }

        public void Dispose()
        {
            container.Dispose();
        }
    }
}