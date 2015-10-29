namespace PetStore.Services
{
    using Data;
    using Data.Migrations;
    using System.Data.Entity;
    using System.Web;
    using System.Web.Http;


    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            DatabaseConfig.Initialize();

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
