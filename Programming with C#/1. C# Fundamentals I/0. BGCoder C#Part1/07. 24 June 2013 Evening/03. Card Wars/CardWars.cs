using System;
using System.IO;
using System.Numerics;

class CardWars
{
    static void Main()
    {
        // http://bgcoder.com/Contests/Practice/Index/93#2

        //if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
        //{
        //    Console.SetIn(new StreamReader("input.txt"));
        //}

        int numberOfGames = int.Parse(Console.ReadLine());

        int scoreFirstPlayer = 0;
        int scoreSecondPlayer = 0;
        int winsFirstPlayer = 0;
        int winsSecondPlaer = 0;
        int winMatchFirstPlayer = 0;
        int winMatchSecondPlayer = 0;
        BigInteger totalScoreFirstPlayer = 0;
        BigInteger totalScoreSecondPlayer = 0;

        // input
        for (int i = 0; i < numberOfGames; i++)
        {
            string cardsFirstPlayer = Console.ReadLine() +
                                      Console.ReadLine() +
                                      Console.ReadLine();

            int indexOfZero = 0;

            cardsFirstPlayer = RemoveZeroFromString(cardsFirstPlayer, indexOfZero);


            string cardsSecondPlayer = Console.ReadLine() +
                                       Console.ReadLine() +
                                       Console.ReadLine();

            cardsSecondPlayer = RemoveZeroFromString(cardsSecondPlayer, indexOfZero);

            // null score for next game
            scoreFirstPlayer = 0;
            scoreSecondPlayer = 0;
            winMatchFirstPlayer = 0;
            winMatchSecondPlayer = 0;

            // score for first player
            for (int j = 0; j < cardsFirstPlayer.Length; j++)
            {
                if (cardsFirstPlayer[j] == 'X')
                {
                    winMatchFirstPlayer++;
                    break;
                }
                else
                {
                    if (cardsFirstPlayer[j] == 'Z' || cardsFirstPlayer[j] == 'Y')
                    {
                        totalScoreFirstPlayer = CheckForSpecialCards(cardsFirstPlayer,
                                                             j, totalScoreFirstPlayer);
                    }
                    else
                    {
                        scoreFirstPlayer = GetScoreForGame(scoreFirstPlayer, cardsFirstPlayer[j].ToString());
                    }

                }
            }

            // score for second player
            for (int j = 0; j < cardsSecondPlayer.Length; j++)
            {
                if (cardsSecondPlayer[j] == 'X')
                {
                    winMatchSecondPlayer++;
                    break;
                }
                else
                {
                    if (cardsSecondPlayer[j] == 'Z' || cardsSecondPlayer[j] == 'Y')
                    {
                        totalScoreSecondPlayer = CheckForSpecialCards(cardsSecondPlayer,
                                                             j, totalScoreSecondPlayer);
                        if (i == numberOfGames - 1 && j == cardsSecondPlayer.Length - 1)
                        {
                            if (totalScoreFirstPlayer > totalScoreSecondPlayer)
                            {
                                Console.WriteLine("First player wins!");
                                Console.WriteLine("Score: {0}", totalScoreFirstPlayer);
                                Console.WriteLine("Games won: {0}", winsFirstPlayer);
                                return;
                            }
                            else if (totalScoreFirstPlayer < totalScoreSecondPlayer)
                            {
                                Console.WriteLine("Second player wins!");
                                Console.WriteLine("Score: {0}", totalScoreSecondPlayer);
                                Console.WriteLine("Games won: {0}", winsSecondPlaer);
                                return;
                            }
                            else if (totalScoreFirstPlayer == totalScoreSecondPlayer)
                            {
                                Console.WriteLine("It's a tie!");
                                Console.WriteLine("Score: {0}", totalScoreSecondPlayer);
                                return;
                            }
                        }
                    }
                    else
                    {
                        scoreSecondPlayer = GetScoreForGame(scoreSecondPlayer, cardsSecondPlayer[j].ToString());
                    }
                }
            }

            // check wins

            if (winMatchFirstPlayer > 0 && winMatchSecondPlayer > 0)
            {
                totalScoreFirstPlayer += 50;
                totalScoreSecondPlayer += 50;
            }
            else if (winMatchFirstPlayer > 0)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (winMatchSecondPlayer > 0)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }
            else if (scoreFirstPlayer > scoreSecondPlayer)
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

        if (winsFirstPlayer > winsSecondPlaer)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", totalScoreFirstPlayer);
            Console.WriteLine("Games won: {0}", winsFirstPlayer);
        }
        else if (winsFirstPlayer < winsSecondPlaer)
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

    private static string RemoveZeroFromString(string cardsPlayer, int indexOfZero)
    {
        for (int i = 0; i < cardsPlayer.Length; i++)
        {
            indexOfZero = cardsPlayer.IndexOf('0');

            if (indexOfZero > 0)
            {
                cardsPlayer = cardsPlayer.Remove(indexOfZero, 1);
                i = indexOfZero - 1;
                indexOfZero = 0;
            }
        }
        return cardsPlayer;
    }

    private static BigInteger CheckForSpecialCards(string cardPlayer, int j, BigInteger totalScore)
    {
        if (cardPlayer[j] == 'Y')
        {
            totalScore -= 200;
        }
        else if (cardPlayer[j] == 'Z')
        {
            totalScore *= 2;

        }

        return totalScore;
    }

    private static int GetScoreForGame(int scorePlayer, string cardsPlayer)
    {

        switch (cardsPlayer)
        {
            case "2":
                scorePlayer += 10;
                break;
            case "3":
                scorePlayer += 9;
                break;
            case "4":
                scorePlayer += 8;
                break;
            case "5":
                scorePlayer += 7;
                break;
            case "6":
                scorePlayer += 6;
                break;
            case "7":
                scorePlayer += 5;
                break;
            case "8":
                scorePlayer += 4;
                break;
            case "9":
                scorePlayer += 3;
                break;
            case "1":
                scorePlayer += 2;
                break;
            case "A":
                scorePlayer += 1;
                break;
            case "J":
                scorePlayer += 11;
                break;
            case "Q":
                scorePlayer += 12;
                break;
            case "K":
                scorePlayer += 13;
                break;
            default:
                throw new ArgumentException();
                break;
        }
        return scorePlayer;
    }
}