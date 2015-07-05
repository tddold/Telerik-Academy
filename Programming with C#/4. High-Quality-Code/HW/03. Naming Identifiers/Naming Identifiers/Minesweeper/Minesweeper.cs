namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Minesweeper
    {
        private const int MaxScore = 35;

        public static void Main()
        {
            int row = 0;
            int column = 0;
            int counter = 0;
            string commands = string.Empty;
            char[,] playfield = CreatePlayfield();
            char[,] mines = PlaceMines();
            bool isMine = false;
            bool inGame = true;
            bool maxResult = false;
            List<Score> highScores = new List<Score>(6);

            do
            {
                if (inGame)
                {
                    Console.WriteLine("Come to play Minesweeper. Try your luck to find fields without mines." +
                     "Command 'top' shows the ranking, 'restart' start a new game, 'exit' quit the game");
                    PrintPlayfield(playfield);
                    inGame = false;
                }

                Console.WriteLine("Enter row and column: ");
                commands = Console.ReadLine().Trim();

                if (commands.Length >= 3)
                {
                    if (int.TryParse(commands[0].ToString(), out row) &&
                        int.TryParse(commands[2].ToString(), out column) &&
                        row <= playfield.GetLength(0) &&
                        column <= playfield.GetLength(1))
                    {
                        commands = "turn";
                    }
                }

                switch (commands)
                {
                    case "top":
                        PrintHighscores(highScores);
                        break;
                    case "restart":
                        playfield = CreatePlayfield();
                        mines = PlaceMines();
                        PrintPlayfield(playfield);
                        isMine = false;
                        inGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Buy, buy!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                PlayerTurn(playfield, mines, row, column);
                                counter++;
                            }

                            if (MaxScore == counter)
                            {
                                maxResult = true;
                            }
                            else
                            {
                                PrintPlayfield(playfield);
                            }
                        }
                        else
                        {
                            isMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("{0}Error! Invalid command!{0}", Environment.NewLine);
                        break;
                }

                if (isMine)
                {
                    PrintPlayfield(mines);
                    Console.WriteLine("{0}You died with {1} points. Enter your nickname: ", Environment.NewLine, counter);
                    string nickname = Console.ReadLine();
                    Score result = new Score(nickname, counter);

                    if (highScores.Count < 5)
                    {
                        highScores.Add(result);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].Point < result.Point)
                            {
                                highScores.Insert(i, result);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((Score result1, Score result2) => result2.Name.CompareTo(result1.Name));
                    highScores.Sort((Score result1, Score result2) => result2.Point.CompareTo(result1.Point));

                    playfield = CreatePlayfield();
                    mines = PlaceMines();
                    counter = 0;
                    isMine = false;
                    inGame = true;
                }

                if (maxResult)
                {
                    Console.WriteLine("{0}Congratulations! You opened all 35 fields!", Environment.NewLine);
                    PrintPlayfield(mines);
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Score result = new Score(name, counter);
                    highScores.Add(result);
                    PrintHighscores(highScores);
                    playfield = CreatePlayfield();
                    mines = PlaceMines();
                    counter = 0;
                    maxResult = false;
                    inGame = true;
                }
            } 
            while (commands != "exit");

            Console.WriteLine("Made in Bulgaria. Press any kay to exit!");
            Console.Read();
        }

        private static void PrintHighscores(List<Score> highScores)
        {
            Console.WriteLine("{0}Points", Environment.NewLine);

            if (highScores.Count > 0)
            {
                for (int i = 0; i < highScores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, highScores[i].Name, highScores[i].Point);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty ranklist!{0}", Environment.NewLine);
            }
        }

        private static void PlayerTurn(char[,] playfield, char[,] mines, int row, int column)
        {
            char minesCount = CountMines(mines, row, column);
            mines[row, column] = minesCount;
            playfield[row, column] = minesCount;
        }

        private static void PrintPlayfield(char[,] playfield)
        {
            int rows = playfield.GetLength(0);
            int cols = playfield.GetLength(1);
            Console.WriteLine("{0}  0 1 2 3 4 5 6 7 8 9", Environment.NewLine);
            Console.WriteLine(" ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", playfield[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine(" --------------------{0}", Environment.NewLine);
        }

        private static char[,] CreatePlayfield()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] board = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();

            while (mines.Count < 15)
            {
                Random random = new Random();
                int newRandum = random.Next(50);

                if (!mines.Contains(newRandum))
                {
                    mines.Add(newRandum);
                }
            }

            foreach (int mine in mines)
            {
                int column = (mine / cols);
                int row = (mine % cols);

                if (row == 0 && mine != 0)
                {
                    column--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                board[column, row - 1] = '*';
            }

            return board;
        }
      
        private static char CountMines(char[,] mines, int row, int column)
        {
            int count = 0;
            int rows = mines.GetLength(0);
            int cols = mines.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mines[row - 1, column] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (mines[row + 1, column] == '*')
                {
                    count++;
                }
            }

            if (column - 1 >= 0)
            {
                if (mines[row, column - 1] == '*')
                {
                    count++;
                }
            }

            if (column + 1 < cols)
            {
                if (mines[row, column + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (mines[row - 1, column - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < cols))
            {
                if (mines[row - 1, column + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (mines[row + 1, column - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < cols))
            {
                if (mines[row + 1, column + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
