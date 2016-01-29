//namespace TicTacToe.Web.Controllers
//{
//    using System.Linq;
//    using System.Web.Http;

//    using Microsoft.AspNet.Identity;

//    using TicTacToe.Data;
//    using TicTacToe.Models;
//    using System;
//    using TicTacToe.Web.DataModels;
//    using System.Text;
//    using TicTacToe.GameLogic;
//    using TicTacToe.Web.Infrastructure;

//    [Authorize]
//    public class GamesController : BaseApiController
//    {
//        private IGameResultValidator resultValidator;
//        private IUserIdProvider userIdProvider;

//        public GamesController(
//            ITicTacToeData data,
//            IGameResultValidator resultValidator,
//            IUserIdProvider userIdProvider)
//            : base(data)
//        {
//            this.resultValidator = resultValidator;
//            this.userIdProvider = userIdProvider;
//        }

//        [HttpGet]
//        [AllowAnonymous]
//        public IHttpActionResult ListGames()
//        {
//            var games =
//                this.data.Games.All()
//                    .Select(
//                        g =>
//                        new GameInfoDataModel()
//                        {
//                            Board = g.Board,
//                            Id = g.Id,
//                            State = g.State,
//                            FirstPlayerName = g.FirstPlayer.UserName,
//                            SecondPlayerName = g.SecondPlayer.UserName,
//                        })
//                    .ToList();

//            if (games.Count == 0)
//            {
//                return this.NotFound();
//            }

//            return this.Ok(games);

//        }

//        [HttpPost]
//        public IHttpActionResult Create()
//        {
//            var currentUserId = this.userIdProvider.GetUserId();

//            //// Check whether the player has already created a game which is waiting someone else to enter
//            //var game =
//            //    this.data.Games
//            //        .All()
//            //        .FirstOrDefault(g => g.State == GameState.WaitingForSecondPlayer && g.FirstPlayerId == currentUserId);

//            //if (game != null)
//            //{
//            //    return this.Ok(game.Id);
//            //}

//            var game = new Game
//            {
//                FirstPlayerId = currentUserId,
//            };

//            this.data.Games.Add(game);
//            this.data.SaveChanges();

//            return this.Ok(game.Id);
//        }

//        [HttpPost]
//        public IHttpActionResult Join(Guid id)
//        {
//            var currentUserId = this.userIdProvider.GetUserId();

//            var game = this.data.Games
//                  .Find(id);


//            if (game == null)
//            {
//                return this.NotFound();
//            }

//            if (game.State == GameState.WonByO || game.State == GameState.WonByX || game.State == GameState.Draw)
//            {
//                return this.BadRequest("This game has already finished!");
//            }

//            if (game.FirstPlayerId != currentUserId && (game.SecondPlayerId != null && game.SecondPlayerId != currentUserId))
//            {
//                return this.BadRequest("The game is already full!");
//            }

//            if (game.State == GameState.WaitingForSecondPlayer && game.FirstPlayerId != currentUserId)
//            {
//                game.SecondPlayerId = currentUserId;
//                game.State = GameState.TurnX;
//            }


//            this.data.SaveChanges();

//            return Ok(game.Id);
//        }

//        [HttpGet]
//        public IHttpActionResult Status(Guid id)
//        {
//            var currentUserId = this.userIdProvider.GetUserId();
//            var idAsGuid = id;

//            var game = this.data.Games.All()
//                .Where(x => x.Id == idAsGuid)
//                .Select(x => new { x.FirstPlayerId, x.SecondPlayerId })
//                .FirstOrDefault();
//            if (game == null)
//            {
//                return this.NotFound();
//            }

//            if (game.FirstPlayerId != currentUserId &&
//                game.SecondPlayerId != currentUserId)
//            {
//                return this.BadRequest("This is not your game!");
//            }

//            var gameInfo = this.data.Games.All()
//                .Where(g => g.Id == idAsGuid)
//                .Select(g => new GameInfoDataModel()
//                {
//                    Board = g.Board,
//                    Id = g.Id,
//                    State = g.State,
//                    FirstPlayerName = g.FirstPlayer.UserName,
//                    SecondPlayerName = g.SecondPlayer.UserName,
//                })
//                .FirstOrDefault();

//            return Ok(gameInfo);
//        }

//        /// <param name="row">1,2 or 3</param>
//        /// <param name="col">1,2 or 3</param>
//        [HttpPost]
//        public IHttpActionResult Play(PlayRequestDataModel request)
//        {
//            var currentUserId = this.userIdProvider.GetUserId();

//            if (request == null || !ModelState.IsValid)
//            {
//                return this.BadRequest(ModelState);
//            }

//            var idAsGuid = new Guid(request.GameId);

//            var game = this.data.Games.Find(idAsGuid);
//            if (game == null)
//            {
//                return this.BadRequest("Invalid game id!");
//            }

//            if (game.FirstPlayerId != currentUserId &&
//                game.SecondPlayerId != currentUserId)
//            {
//                return this.BadRequest("This is not your game!");
//            }

//            if (game.State != GameState.TurnX &&
//                game.State != GameState.TurnO)
//            {
//                return this.BadRequest("Invalid game state!");
//            }

//            if ((game.State == GameState.TurnX &&
//                game.FirstPlayerId != currentUserId)
//                ||
//                (game.State == GameState.TurnO &&
//                game.SecondPlayerId != currentUserId))
//            {
//                return this.BadRequest("It's not your turn!");
//            }

//            var positionIndex = (request.Row - 1) * 3 + request.Col - 1;
//            if (game.Board[positionIndex] != '-')
//            {
//                return this.BadRequest("Invalid position!");
//            }

//            // Update games state and board
//            var boardAsStringBuilder = new StringBuilder(game.Board);
//            boardAsStringBuilder[positionIndex] =
//                game.State == GameState.TurnX ? 'X' : 'O';
//            game.Board = boardAsStringBuilder.ToString();

//            game.State = game.State == GameState.TurnX ?
//                GameState.TurnO : GameState.TurnX;

//            this.data.SaveChanges();

//            var gameResult = this.resultValidator.GetResult(game.Board);
//            switch (gameResult)
//            {
//                case GameResult.NotFinished:
//                    break;
//                case GameResult.WonByX:
//                    game.State = GameState.WonByX;
//                    this.data.SaveChanges();
//                    break;
//                case GameResult.WonByO:
//                    game.State = GameState.WonByO;
//                    this.data.SaveChanges();
//                    break;
//                case GameResult.Draw:
//                    game.State = GameState.Draw;
//                    this.data.SaveChanges();
//                    break;
//                default:
//                    break;
//            }

//            return this.Ok();
//        }
//    }
//}