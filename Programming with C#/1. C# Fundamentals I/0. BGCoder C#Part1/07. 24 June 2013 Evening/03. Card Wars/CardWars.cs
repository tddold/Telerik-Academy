using System;
using System.IO;
using System.Numerics;

class CardWars
{
    static void Main()
    {
        // http://bgcoder.com/Contests/Practice/Index/93#2

        if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }


        int numberOfGames = int.Parse(Console.ReadLine());

        const int numberCards = 3;

        int winsFirstPlayer = 0;
        int winsSecondPlaer = 0;
       // int winMatchFirstPlayer = 0;
       // int winMatchSecondPlayer = 0;

        BigInteger totalScoreFirstPlayer = 0;
        BigInteger totalScoreSecondPlayer = 0;

        bool isXCardFirstPlayer = false;
        bool isXCardSecondPlayer = false;

        // input
        for (int i = 0; i < numberOfGames; i++)
        {
            // score for first player
            int scoreFirstPlayer = 0;
            for (int j = 0; j < numberCards; j++)
            {
                string cardsFirstPlayer = Console.ReadLine();

                switch (cardsFirstPlayer)
                {
                    case "A":
                        scoreFirstPlayer += 1;
                        break;
                    case "J":
                        scoreFirstPlayer += 11;
                        break;
                    case "Q":
                        scoreFirstPlayer += 12;
                        break;
                    case "K":
                        scoreFirstPlayer += 13;
                        break;
                    case "Z":
                        totalScoreFirstPlayer *= 2;
                        break;
                    case "Y":
                        totalScoreFirstPlayer -= 200;
                        break;
                    case "X":
                        isXCardFirstPlayer = true;
                        break;
                    default:
                        scoreFirstPlayer += 12 - int.Parse(cardsFirstPlayer);
                        break;
                }
            }

            // score for second player  
            int scoreSecondPlayer = 0;
            for (int j = 0; j < numberCards; j++)
            {
                string cardsSecondPlayer = Console.ReadLine();

                switch (cardsSecondPlayer)
                {
                    case "A":
                        scoreSecondPlayer += 1;
                        break;
                    case "J":
                        scoreSecondPlayer += 11;
                        break;
                    case "Q":
                        scoreSecondPlayer += 12;
                        break;
                    case "K":
                        scoreSecondPlayer += 13;
                        break;
                    case "Z":
                        totalScoreSecondPlayer *= 2;
                        break;
                    case "Y":
                        totalScoreSecondPlayer -= 200;
                        break;
                    case "X":
                        isXCardSecondPlayer = true;
                        break;
                    default:
                        scoreSecondPlayer += 12 - int.Parse(cardsSecondPlayer);
                        break;
                }
            }

            // check wins
            if (isXCardFirstPlayer && isXCardSecondPlayer)
            {
                totalScoreFirstPlayer += 50;
                totalScoreSecondPlayer += 50;

                isXCardFirstPlayer = false;
                isXCardSecondPlayer = false;
            }
            else if (isXCardFirstPlayer)
            {
                break;
            }
            else if (isXCardSecondPlayer)
            {
                break;
            }
            
            if (scoreFirstPlayer > scoreSecondPlayer)
            {
                winsFirstPlayer++;
                totalScoreFirstPlayer += scoreFirstPlayer;
            }
            else if (scoreFirstPlayer < scoreSecondPlayer)
            {
                winsSecondPlaer++;
                totalScoreSecondPlayer += scoreSecondPlayer;
            }
        }

        if (isXCardFirstPlayer)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
        }
        else if (isXCardSecondPlayer)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
        }
        else if (totalScoreFirstPlayer > totalScoreSecondPlayer)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", totalScoreFirstPlayer);
            Console.WriteLine("Games won: {0}", winsFirstPlayer);
        }
        else if (totalScoreFirstPlayer < totalScoreSecondPlayer)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", totalScoreSecondPlayer);
            Console.WriteLine("Games won: {0}", winsSecondPlaer);
        }
        else if (totalScoreFirstPlayer == totalScoreSecondPlayer)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", totalScoreSecondPlayer);
        }
    }
}