using CV.CrossCutting.Identity;
using CV.Infraestructure.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Owin;

namespace CV.CrossCutting.Service
{
    public static class OwinService
    {

        public static void ConfigureCrossCutting(IAppBuilder app)
        {
            app.CreatePerOwinContext<IdentityDbContext<IdentityUser>>(CVContext.Create);
            app.CreatePerOwinContext<UserManager<IdentityUser>>(ApplicationUserManager.Create);
            app.CreatePerOwinContext<SignInManager<IdentityUser, string>>(ApplicationSignInManager.Create);
        }

    }
}
