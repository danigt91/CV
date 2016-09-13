using Microsoft.Practices.Unity;
using CV.CrossCutting.IoC;
using System;

namespace CV.CrossCutting.Service
{
    public static class DependencyResolverService
    {

        static UnityContainer _container;

        public static void Register()
        {
            _container = new PrincipalContainer();
        }

        public static void Register<I, C>() where C : I
        {
            _container.RegisterType<I, C>();
        }

        public static void Register<I>(InjectionFactory ifac)
        {
            _container.RegisterType<I>(ifac);
        }

        public static I ResolveCustomType<I>()
        {
            return _container.Resolve<I>();
        }

        public static UnityContainer GetContainer()
        {
            return _container;
        }

    }
}
