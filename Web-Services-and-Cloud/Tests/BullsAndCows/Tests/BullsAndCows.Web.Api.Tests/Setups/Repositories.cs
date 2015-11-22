namespace BullsAndCows.Web.Api.Tests.Setups
{
    using BullsAndCows.Data.Models;
    using BullsAndCows.Data.Repositories;
    using Moq;
    using System.Collections.Generic;
    using System.Linq;

    public static class Repositories
    {
        public static IRepository<Game> GetGamesrRepository()
        {
            var repository = new Mock<IRepository<Game>>();

            repository.Setup(r => r.All())
                .Returns(() =>
                {
                    return new List<Game>
                    {
                       new Game { GameState = GameState.WaitingForOpponent, Name="B", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"} },
                       new Game { GameState = GameState.Finished,Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.WaitingForOpponent, Name="C", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.Finished,Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.WaitingForOpponent, Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.Finished,Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.WaitingForOpponent, Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.Finished,Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.WaitingForOpponent, Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.Finished,Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.WaitingForOpponent, Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.Finished,Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.WaitingForOpponent, Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.Finished,Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.WaitingForOpponent, Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                       new Game { GameState = GameState.Finished,Name="A", RedUser= new User { Email = "Red"}, BlueUser= new User { Email = "Blue"}},
                    }.AsQueryable();
                });

            return repository.Object;
        }

        public static IRepository<User> GetUserRepository()
        {
            var repository = new Mock<IRepository<User>>();

            repository.Setup(r => r.All())
                .Returns(() =>
                {
                    return new List<User>
                    {
                        new User {Email = "TestUser 1", Rank = 100 },
                        new User {Email = "TestUser 2", Rank = 50 },
                        new User {Email = "TestUser 3", Rank = 4500 },
                        new User {Email = "TestUser 4", Rank = 200 },
                        new User {Email = "TestUser 5", Rank = 100 },
                        new User {Email = "TestUser 6", Rank = 80 },
                        new User {Email = "TestUser 7", Rank = 3510 },
                        new User {Email = "TestUser 8", Rank = 200 },
                        new User {Email = "TestUser 9", Rank = 13450 },
                        new User {Email = "TestUser 10", Rank = 50 },
                        new User {Email = "TestUser 10", Rank = 3500 },
                        new User {Email = "TestUser 10", Rank = 500 },
                    }.AsQueryable();
                });

            return repository.Object;
        }
    }
}
