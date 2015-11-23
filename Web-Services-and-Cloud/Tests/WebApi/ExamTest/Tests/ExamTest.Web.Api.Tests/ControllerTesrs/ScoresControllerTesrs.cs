namespace ExamTest.Web.Api.Tests.ControllerTesrs
{
    using System.Collections.Generic;
    using System.Linq;
    using Controllers;
    using ExamTest.Web.Api.Tests.Setups;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models.HighScore;
    using MyTested.WebApi;

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
            this.controller
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
