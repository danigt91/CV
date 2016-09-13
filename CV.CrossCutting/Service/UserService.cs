using CV.CrossCutting.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CV.CrossCutting.Service
{
    public class UserService
    {

        private UserManager<IdentityUser> _userManager;

        public UserService(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }


        public UserManager<IdentityUser> GetUserManager()
        {
            return _userManager;
        }

        public async Task<IdentityResult> CreateUserAsync(IdentityUser user, string password)
        {
            IdentityResult userIdentity = null;
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            //userIdentity = await manager.CreateIdentityAsync(user, authenticationType);
            userIdentity = await _userManager.CreateAsync(user, password);
            // Add custom user claims here
            return userIdentity;
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(IdentityUser user, string authenticationType)
        {
            ClaimsIdentity userIdentity = null;
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            userIdentity = await _userManager.CreateIdentityAsync(user, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }


    }
}
