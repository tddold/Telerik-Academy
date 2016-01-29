using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_06.TicTacToe.Web.Startup))]
namespace _06.TicTacToe.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
