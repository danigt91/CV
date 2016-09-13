using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using CV.CrossCutting.Service;

[assembly: OwinStartup(typeof(CV.Startup))]

namespace CV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            OwinService.ConfigureCrossCutting(app);
            ConfigureAuth(app);
            //app.MapSignalR();
        }
    }
}
