namespace BullsAndCows.Web.Api.Tests.ControllerTesrs
{
    using Controllers;
    using BullsAndCows.Web.Api.Tests.Setups;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyTested.WebApi;
    using System.Collections.Generic;
    using Models.HighScore;
    using System.Linq;

    [TestClass]
    public class ScoresControllerTesrs
    {
        private IControllerBuilder<ScoresController> controller;

        [TestInitialize]
        public void Init()
        {
            this.controller = MyWebApi
                .Controller<ScoresController>()
                .WithResolvedDependencies(Services.GetHighScoreService());
        }

        [TestMethod]
        public void GetShoildReturnCorrectHighScore()
        {
            controller
                 .Calling(c => c.Get())
                 .ShouldReturn()
                 .Ok()
                 .WithResponseModelOfType<List<HighScoreResponseModel>>()
                 .Passing(model =>
                 {
                     Assert.AreEqual(10, model.Count);

                     var current = model.First().Rank;
                     for (int i = 1; i < model.Count; i++)
                     {
                         Assert.IsTrue(model[i].Rank <= current);
                         current = model[i].Rank;
                     }
                 });
        }
    }
}
