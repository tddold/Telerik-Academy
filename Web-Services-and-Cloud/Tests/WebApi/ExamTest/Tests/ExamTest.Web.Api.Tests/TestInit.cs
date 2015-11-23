namespace ExamTest.Web.Api.Tests
{
    using Common.Constants;
    using Data.Models;
    using Data.Repositories;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Setups;

    [TestClass]
    public static class TestInit
    {
        [AssemblyInitialize]
        public static void Init(TestContext testContext)
        {
            NinjectConfig.DependenciesRegistration = kernel =>
            {
                kernel.Bind<IRepository<User>>().ToConstant(Repositories.GetUserRepository());
            };

            AutoMapperConfig.RegisterMappings(Assemblies.WebApi);
        }
    }
}
