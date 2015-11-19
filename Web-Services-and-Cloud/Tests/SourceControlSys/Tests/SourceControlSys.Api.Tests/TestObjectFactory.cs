namespace SourceControlSys.Api.Tests
{
    using SourceControlSys.Services.Data.Constracts;
    using Moq;
    using Models.Projects;

    public static class TestObjectFactory
    {
        public static IProjectsService GetProjectsService()
        {
            var projectsService = new Mock<IProjectsService>();
            projectsService.Setup(pr => pr.Add(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<bool>())).Returns(1);

            return projectsService.Object;
        }

        public static SaveProjectResponseModel GetInvalidModel()
        {
            return new SaveProjectResponseModel { Description = "TestDescription" };
        }
    }
}
