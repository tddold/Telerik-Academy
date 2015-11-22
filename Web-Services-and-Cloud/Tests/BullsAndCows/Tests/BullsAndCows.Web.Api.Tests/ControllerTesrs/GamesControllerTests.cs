namespace BullsAndCows.Web.Api.Tests.ControllerTesrs
{
    using Models.Games;
    using BullsAndCows.Web.Api.Tests.Setups;
    using Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyTested.WebApi;
    using System.Collections.Generic;
    using Common.Constants;

    [TestClass]
    public class GamesControllerTests
    {
        [TestMethod]
        public void GetShouldReturnWaitingForOponentGamesWhitoutAuthenticatedUser()
        {
            MyWebApi
                .Controller<GamesController>()
                .WithResolvedDependencies(Services.GetGameService(), Services.GetGuessService())
                .Calling(c => c.Get("1"))
                .ShouldReturn()
                .Ok()
                .WithResponseModelOfType<List<ListedGameResponseModel>>()
                .Passing(model => model.Count == GameConstants.GamePerPages);
        }

        [TestMethod]
        public void GetShouldReturnWaitingForOponentGamesWhitoutAuthenticatedUserAndPaging()
        {
            MyWebApi
                .Controller<GamesController>()
                .WithResolvedDependencies(Services.GetGameService(), Services.GetGuessService())
                .Calling(c => c.Get("100"))
                .ShouldReturn()
                .Ok()
                .WithResponseModelOfType<List<ListedGameResponseModel>>()
                .Passing(model => model.Count == 0);
        }
    }
}
