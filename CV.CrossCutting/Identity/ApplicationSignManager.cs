using CV.CrossCutting.Service;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CV.CrossCutting.Identity
{
    // Configure the application sign-in manager which is used in this application.
    public class ApplicationSignInManager : SignInManager<IdentityUser, string>
    {


        public ApplicationSignInManager(UserManager<IdentityUser> userManager, 
            IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }
        

        public static SignInManager<IdentityUser, string> Create(IdentityFactoryOptions<SignInManager<IdentityUser, string>> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<UserManager<IdentityUser>>(), context.Authentication);
        }
    }
}
