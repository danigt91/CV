using Microsoft.Practices.Unity;
using CV.CrossCutting.IoC;

namespace CV.CrossCutting.Service
{
    public static class DependencyResolverService
    {

        static UnityContainer _container;

        public static UnityContainer Register()
        {
            _container = new PrincipalContainer();
            return _container;
        }

        public static I ResolveCustomType<I>()
        {
            return _container.Resolve<I>();
        }

    }
}
