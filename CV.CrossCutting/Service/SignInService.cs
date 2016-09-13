using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.CrossCutting.Service
{
    public class SignInService
    {
        
        private SignInManager<IdentityUser, string> _signInManager;

        public SignInService(SignInManager<IdentityUser, string> signInManager)
        {
            _signInManager = signInManager;
        }        

        public SignInManager<IdentityUser, string> GetSignInManager()
        {
            return _signInManager;
        }

        public async Task<SignInStatus> LoginUserAsync(string user, string password, bool remember)
        {
            SignInStatus signStatus = await _signInManager.PasswordSignInAsync(user, password, remember, false);

            return signStatus;
        }

    }
}
