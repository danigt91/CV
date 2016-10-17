using Microsoft.Practices.Unity;
using CV.Infraestructure.Data;
using CV.Infraestructure.Data.Contract;
using CV.Infraestructure.Data.Entity;
using CV.Infraestructure.Data.Entity.Contract;
using CV.Infraestructure.Data.Repository;
using CV.Infraestructure.Data.Repository.Contract;
using CV.Infraestructure.Data.Repository.Implementation;
using Microsoft.AspNet.Identity.EntityFramework;
using CV.CrossCutting.Identity;
using Microsoft.AspNet.Identity;
using CV.Infraestructure.Service.Contract;
using CV.Infraestructure.Service.Implementation;
using CV.Domain.Service.Contract;
using CV.Domain.Service.Implementation;

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
