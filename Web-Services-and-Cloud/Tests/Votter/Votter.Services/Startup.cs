using Microsoft.Owin;
[assembly: OwinStartup(typeof(Votter.Services.Startup))]

namespace Votter.Services
{
    using System;
    using System.Linq;
    using Owin;


    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}