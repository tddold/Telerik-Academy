namespace _06.TicTacToe.Web.GameLogic
{
    public class GameResultValidator : IGameResultValidator
    {
        public GameResult GetResult(string board)
        {
            if (this.IsGameWonBySymbol(board, 'O'))
            {
                return GameResult.WonByO;
            }

            if (this.IsGameWonBySymbol(board, 'X'))
            {
                return GameResult.WonByX;
            }

            if (board.IndexOf('-') < 0)
            {
                return GameResult.Draw;
            }

            return GameResult.NotFinished;
        }

        private bool IsGameWonBySymbol(string board, char symbol)
        {
            if ((board[2] == board[4] && board[4] == board[6] && board[2] == symbol) ||
                (board[0] == board[4] && board[4] == board[8] && board[0] == symbol))
            {
                return true;
            }

            for (int i = 0; i < 3; i++)
            {
                int sumVert = 0;
                int sumHor = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (board[j * 3 + i] == symbol)
                    {
                        sumVert++;
                    }

                    if (board[i * 3 + j] == symbol)
                    {
                        sumHor++;
                    }
                }
                if (sumVert == 3 || sumHor == 3)
                {
                    return true;
                }
            }

            return false;
        }

    }
}