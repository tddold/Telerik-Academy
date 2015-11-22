namespace BullsAndCows.Web.Api.Tests.Setups
{
    using BullsAndCows.Services.Data;
    using BullsAndCows.Services.Data.Contracts;

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
