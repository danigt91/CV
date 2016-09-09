using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CV.CrossCutting.Service;
using CV.Presentation.Engines;

namespace CV
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            // Unity Injection
            DependencyResolverService.Register();

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new MyRazorViewEngine());
        }

    }
}
