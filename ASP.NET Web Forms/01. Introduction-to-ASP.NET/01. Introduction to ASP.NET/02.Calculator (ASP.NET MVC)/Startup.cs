using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_02.Calculator__ASP.NET_MVC_.Startup))]
namespace _02.Calculator__ASP.NET_MVC_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
