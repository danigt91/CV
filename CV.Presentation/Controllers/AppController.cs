using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Models.App;

namespace CV.Controllers
{
    public class AppController : Controller
    {

        public PartialViewResult MenuPublico()
        {

            var enlaces = new List<EnlaceViewModel>();
            enlaces.Add(new EnlaceViewModel()
            {
                //Url = URLDecode("Index", "Home", new { area = "" }),
                Url = "home.index",
                Texto = "Home"
            });
            enlaces.Add(new EnlaceViewModel()
            {
                //Url = URLDecode("Index", "Video", new { area = "" }),
                Url = "video.index",
                Texto = "Video Streamming"
            });
            enlaces.Add(new EnlaceViewModel()
            {
                //Url = URLDecode("Index", "Video", new { area = "" }),
                Url = "account.index",
                Texto = "Register"
            });

            return PartialView("_MenuPublic", enlaces);
        }

        private string URLDecode(string action, string controller, object attributes = null)
        {
            var url = "";
            if (attributes != null)
                url = Url.Action(action, controller, attributes);
            else
                url = Url.Action(action, controller);
            url = HttpUtility.UrlDecode(url);
            return url;
        }

    }
}