namespace ExamTest.Web.Api.Tests.Setups
{
    using ExamTest.Services.Data;
    using ExamTest.Services.Data.Contracts;

    public static class Services
    {
        public static IHighScoreService GetHighScoreService()
        {
            return new HighScoreService(Repositories.GetUserRepository());
        }

        public static IGameService GetGameService()
        {
            return new GamesService(null, Repositories.GetGamesrRepository(), null);
        }

        public static IGuessService GetGuessService()
        {
            return new GuessService(null, null);
        }
    }
}
