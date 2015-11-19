namespace SourceControlSys.Api.Tests.RouteTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyTested.WebApi;
    using Controllers;
    using System.Net.Http;
    using Models.Projects;
    using System.Web.Http;

    [TestClass]
    public class ProjectsControllerTests
    {
        [TestInitialize]
        public void Init()
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            MyWebApi.IsUsing(WebApiConfig.Config);
        }

        [TestMethod]
        public void PosrShouldMapCorrectly()
        {
            // tests whether the route is resolved
            // with valid model state
            MyWebApi
                .Routes()
                .ShouldMap("api/Projects")
                .WithHttpMethod(HttpMethod.Post)
                .WithJsonContent(@"{""Name"":""Test"",""Private"":true}")
                .To<ProjectsController>(c => c.Post(new SaveProjectResponseModel
                {
                    Name = "Test",
                    Private = true
                }));
        }

    }
}
