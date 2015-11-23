namespace ExamTest.Services.Data.Contracts
{
    using System.Linq;
    using ExamTest.Data.Models;

    public interface IHighScoreService
    {
        IQueryable<User> GetLatest();

        void UpdateRank(string userId, bool won);
    }
}