using Microsoft.Practices.Unity;
using CV.Infraestructure.Data;
using CV.Infraestructure.Data.Contract;
using Microsoft.AspNet.Identity.EntityFramework;
using CV.CrossCutting.Identity;
using Microsoft.AspNet.Identity;
using CV.Domain.Service.Contract;
using CV.Domain.Service.Implementation;
using CV.Domain.Data.Repository;
using CV.Domain.Data.Entity;
using CV.Infraestructure.Data.Persistence.Contract;
using CV.Infraestructure.Data.Persistence.Implementation;
using CV.Infraestructure.Data.Repository;

namespace CV.CrossCutting.IoC
{
    class PrincipalContainer : UnityContainer
    {

        public PrincipalContainer() : base()
        {

            InfraestructureInjection();

        }

        private void InfraestructureInjection()
        {
            /* OWIN */
            this.RegisterType<IdentityUser, ApplicationUser>();
            this.RegisterType<IdentityDbContext<IdentityUser>, CVContext>();

            var accountInjectionConstructor = new InjectionConstructor(new IdentityDbContext<IdentityUser>());
            this.RegisterType<IUserStore<IdentityUser>, UserStore<IdentityUser>>(accountInjectionConstructor);
            this.RegisterType<UserManager<IdentityUser>, ApplicationUserManager>();

            /* Arquitectura */
            this.RegisterType<IContext, CVContext>();
            this.RegisterType<IUnitOfWork<IContext>, UnitOfWork>();            

            /* Repositorio de entidades */
            this.RegisterType(typeof(IDataRepository<>), typeof(DataRepository<>));
            this.RegisterType(typeof(IAutoMapperEF6<,>), typeof(AutoMapperEF6<,>));

            /* Repository de servicios */
            this.RegisterType<IUsuarioService, UsuarioService>();
        }

    }
}
