using CV.CrossCutting.Service;
using CV.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;

namespace CV.Presentation.Controllers
{
    public class AccountWebController : Controller
    {

        private UserService _userService;
        private SignInService _signInService;


        public AccountWebController(UserService identityService)
        {
            _userService = identityService;
        }

        // GET: AccountWeb
        public ActionResult Register()
        {
            return PartialView();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.GetUserManager().FindAsync(model.Email, model.Password);
                if (user != null)
                {
                    await _signInService.GetSignInManager().SignInAsync(user, true, true);
                    return Redirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }


    }
}