namespace SourceControlSys.Api.Tests.ControllerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Controllers;
    using System.Web.Http;
    using System.Web.Http.Results;
    using MyTested.WebApi;
    using Services.Data.Constracts;
    using System.Collections.Generic;
    using Models.Projects;

    [TestClass]
    public class ProjectsControllerTests
    {
        [TestMethod]
        public void PostShouldValidateModelState()
        {
            var controller = new ProjectsController(TestObjectFactory.GetProjectsService());
            controller.Configuration = new HttpConfiguration();

            var model = TestObjectFactory.GetInvalidModel();

            controller.Validate(model);

            var result = controller.Post(model);

            Assert.IsFalse(controller.ModelState.IsValid);
        }

        [TestMethod]
        public void PostShouldReturnBadRequestWithInvalidModel()
        {
            var controller = new ProjectsController(TestObjectFactory.GetProjectsService());
            controller.Configuration = new HttpConfiguration();

            var model = TestObjectFactory.GetInvalidModel();

            controller.Validate(model);

            var result = controller.Post(model);

            Assert.AreEqual(typeof(InvalidModelStateResult), result.GetType());
        }

        [TestMethod]
        public void PostShouldValidateOkResult()
        {
            // tests whether the action returns OkResult
            MyWebApi
                .Controller<ProjectsController>()
                .Calling(c => c.Get())
                .ShouldReturn()
                .Ok();
        }

        [TestMethod]
        public void PostShouldReturnBadRequestWithInvalidModelMyApi()
        {
            MyWebApi
                .Controller<ProjectsController>()
                .WithResolvedDependencyFor<IProjectsService>(TestObjectFactory.GetProjectsService())
                .Calling(c => c.Get())
                .ShouldHave()
                .ActionAttributes(attr => attr.RestrictingForAuthorizedRequests())
                .AndAlso()
                .ShouldReturn()
                .Ok()
                .WithResponseModelOfType<List<SoftwareProjectDetailResponseModel>>();

        }

    }
}
