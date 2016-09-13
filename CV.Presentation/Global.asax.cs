using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CV.CrossCutting.Service;
using CV.Presentation.Engines;
using Microsoft.AspNet.Identity.EntityFramework;
using CV.Models;
using System.Web.Helpers;
using System.Security.Claims;
using Microsoft.Practices.Unity.Mvc;

namespace CV
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;
            // Unity Injection
            DependencyResolverService.Register();
            DependencyResolver.SetResolver(new UnityDependencyResolver(DependencyResolverService.GetContainer()));
            
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new MyRazorViewEngine());
        }

        protected void Application_BeginRequest()
        {

        }
        protected void Application_EndRequest()
        {

        }
    }
}
