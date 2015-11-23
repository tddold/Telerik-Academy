namespace ExamTest.Services.Data.Contracts
{
    using System.Linq;
    using ExamTest.Data.Models;

    public interface IGuessService
    {
        Guess MakeGuess(int gameId, string number, string userId);

        IQueryable<Guess> GetGuessDetails(int id);
    }
}