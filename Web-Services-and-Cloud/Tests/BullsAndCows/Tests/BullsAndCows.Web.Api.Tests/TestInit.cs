namespace BullsAndCows.Web.Api.Tests
{
    using Data.Repositories;
    using Common.Constants;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Data.Models;
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
