namespace BullsAndCows.Services.Data.Contracts
{
    using System.Linq;
    using BullsAndCows.Data.Models;

    public interface IHighScoreService
    {
        IQueryable<User> GetLatest();

        void UpdateRank(string userId, bool won);
    }
}