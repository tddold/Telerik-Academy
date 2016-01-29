namespace _06.TicTacToe.Web.Models
{
    public enum GameState
    {
        WaitingForSecondPlayer = 0,
        TurnX = 1,
        TurnO = 2,
        WonByX = 3,
        WonByO = 4,
        Draw = 5
    }
}
