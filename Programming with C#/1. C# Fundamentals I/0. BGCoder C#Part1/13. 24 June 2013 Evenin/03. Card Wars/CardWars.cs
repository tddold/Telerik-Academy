using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace _03.Card_Wars
{
    class CardWars
    {
        static void Main()
        {
            //StreamReader reader = new StreamReader("..\\..\\input.txt");
            //Console.SetIn(reader);

            int n = int.Parse(Console.ReadLine());

            BigInteger totalScoreFirstPlayer = 0;
            BigInteger totalScoreSecondPlayer = 0;

            int winsFirstPlayer = 0;
            int winsSecondPlayer = 0;

            bool isXCardFirstPlayer = false;
            bool isXCardSecondPlayer = false;

            for (int i = 0; i < n; i++)
            {
                int currScoreFirstPlayer = 0;
                int currScoreSecondPlayer = 0;

                for (int j = 0; j < 3; j++)
                {
                    string cardFirstPlayer = Console.ReadLine();

                    switch (cardFirstPlayer)
                    {
                        case "A":
                            currScoreFirstPlayer += 1;
                            break;
                        case "J":
                            currScoreFirstPlayer += 11;
                            break;
                        case "Q":
                            currScoreFirstPlayer += 12;
                            break;
                        case "K":
                            currScoreFirstPlayer += 13;
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
                            currScoreFirstPlayer += 12 - int.Parse(cardFirstPlayer);
                            break;
                    }
                }

                for (int j = 0; j < 3; j++)
                {
                    string cardSecondPlayer = Console.ReadLine();

                    switch (cardSecondPlayer)
                    {
                        case "A":
                            currScoreSecondPlayer += 1;
                            break;
                        case "J":
                            currScoreSecondPlayer += 11;
                            break;
                        case "Q":
                            currScoreSecondPlayer += 12;
                            break;
                        case "K":
                            currScoreSecondPlayer += 13;
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
                            currScoreSecondPlayer += 12 - int.Parse(cardSecondPlayer);
                            break;
                    }
                }

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
               
                if (currScoreFirstPlayer > currScoreSecondPlayer)
                {
                    winsFirstPlayer++;
                    totalScoreFirstPlayer += currScoreFirstPlayer;
                }
                else if (currScoreFirstPlayer < currScoreSecondPlayer)
                {
                    winsSecondPlayer++;
                    totalScoreSecondPlayer += currScoreSecondPlayer;
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
                Console.WriteLine("Games won: {0}", winsSecondPlayer);
            }
            else if (totalScoreFirstPlayer == totalScoreSecondPlayer)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", totalScoreSecondPlayer);
            }
        }
    }
}
