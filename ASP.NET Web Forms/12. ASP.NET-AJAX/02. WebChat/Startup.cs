using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_02.WebChat.Startup))]
namespace _02.WebChat
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
