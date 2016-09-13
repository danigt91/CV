using Microsoft.Practices.Unity;
using CV.Infraestructure.Data;
using CV.Infraestructure.Data.Contract;
using CV.Infraestructure.Data.Repository.Contract;
using CV.Infraestructure.Data.Repository.Implementation;
using Microsoft.AspNet.Identity.EntityFramework;
using CV.CrossCutting.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using CV.CrossCutting.Service;
using Microsoft.Owin.Security;
using System.Web;


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
            /* Arquitectura */
            this.RegisterType<IdentityUser, ApplicationUser>();           

            this.RegisterType<IdentityDbContext<IdentityUser>, CVContext>();

            this.RegisterType<IUserStore<IdentityUser>, CustomUserStore>();
            this.RegisterType<UserManager<IdentityUser>, ApplicationUserManager>();

            this.RegisterType<IAuthenticationManager, CustomAuthenticationManager>();
            this.RegisterType<SignInManager<IdentityUser, string>, ApplicationSignInManager>();

            this.RegisterType<UserService>();
            //this.RegisterType<SignInService>();

            this.RegisterType<IContext, CVContext>();
            this.RegisterType<IUnitOfWork<IContext>, UnitOfWork>();

            /* Repositorio de entidades */
            this.RegisterType(typeof(IDataRepository<>), typeof(DataRepository<>));
        }

    }
}
