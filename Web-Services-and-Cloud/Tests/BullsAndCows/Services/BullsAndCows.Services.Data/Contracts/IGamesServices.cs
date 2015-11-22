namespace BullsAndCows.Services.Data.Contracts
{
    using BullsAndCows.Data.Models;
    using System.Linq;

    public interface IGameService
    {
        IQueryable<Game> GetPublicGame(int page = 0, string userId = null);

        Game CreateGame(string name, string number, string userId);

        IQueryable<Game> GetGameDetails(int id);

        bool GameCanBeJoneByUser(int id, string userId);

        string JoinGame(int id, string number, string userId);

        bool CanMakeGuess(int id, string userId);

        void ChangeGameState(int id, bool finished);

        bool UserIsPartOfGame(int id, string userId);
    }
}
