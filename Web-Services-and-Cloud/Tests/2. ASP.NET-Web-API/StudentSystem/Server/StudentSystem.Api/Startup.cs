using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(StudentSystem.Api.Startup))]

namespace StudentSystem.Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
