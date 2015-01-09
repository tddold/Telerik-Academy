using System;
using System.Numerics;

class CardWarsBatka
{

    static void Main()
    {
        //double prb = 0.1;
        //BigInteger test = 0;
        //test = test + prb;
        //Console.WriteLine(prb);
        //return;
        const int bonusX = 50;
        const int p = 3;

        int n = int.Parse(Console.ReadLine());

        int handFirstPlaeyr = 0;
        int handSecondPlaeyr = 0;

        BigInteger scoreFirstPlaeyr = 0;
        BigInteger scoreSecondPlaeyr = 0;

        bool cardXFirst = false;
        bool cardXSecond = false;

        bool gamesWinFirst = false;
        bool gamesWinSecond = false;

        int countWinFirst = 0;
        int countWinSecond = 0;

        string input = String.Empty;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                input = Console.ReadLine();

                // First plaeyr
                if (input == "A")
                {
                    handFirstPlaeyr += 1;
                }
                else if (input == "J")
                {
                    handFirstPlaeyr += 11;
                }
                else if (input == "Q")
                {
                    handFirstPlaeyr += 12;
                }
                else if (input == "K")
                {
                    handFirstPlaeyr += 13;
                }
                else if (input == "Z")
                {
                    handFirstPlaeyr *= 2;
                }
                else if (input == "Y")
                {
                    handFirstPlaeyr -= 200;
                }
                else if (input == "X")
                {
                    cardXFirst = true;
                }
                else
                {
                    handFirstPlaeyr += 12 - int.Parse(input);
                }
            }

            // Second paleyr
            for (int l = 0; l < p; l++)
            {
                input = Console.ReadLine();

                if (input == "A")
                {
                    handSecondPlaeyr += 1;
                }
                else if (input == "J")
                {
                    handSecondPlaeyr += 11;
                }
                else if (input == "Q")
                {
                    handSecondPlaeyr += 12;
                }
                else if (input == "K")
                {
                    handSecondPlaeyr += 13;
                }
                else if (input == "Z")
                {
                    handSecondPlaeyr *= 2;
                }
                else if (input == "Y")
                {
                    handSecondPlaeyr -= 200;
                }
                else if (input == "X")
                {
                    cardXSecond = true;
                }
                else
                {
                    handSecondPlaeyr += 12 - int.Parse(input);
                }
            }

            // Logiks
            if (cardXFirst && cardXSecond)
            {
                scoreFirstPlaeyr += bonusX;
                scoreSecondPlaeyr += bonusX;
            }
            else if (cardXFirst)
            {
                gamesWinFirst = true;
                break;
            }
            else if (cardXSecond)
            {
                gamesWinSecond = true;
                break;
            }
            else if (handFirstPlaeyr > handSecondPlaeyr)
            {
                scoreFirstPlaeyr += handFirstPlaeyr;
                countWinFirst++;
            }
            else if (handFirstPlaeyr < handSecondPlaeyr)
            {
                scoreSecondPlaeyr += handSecondPlaeyr;
                countWinSecond++;
            }
            else if (handFirstPlaeyr == handSecondPlaeyr)
            {                
                continue;
            }

            handFirstPlaeyr = 0;
            handSecondPlaeyr = 0;
        }

        // Output
        if (gamesWinFirst)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
        }
        else if (gamesWinSecond)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
        }
        else if (scoreFirstPlaeyr > scoreSecondPlaeyr)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", scoreFirstPlaeyr);
            Console.WriteLine("Games won: {0}", countWinFirst);
        }
        else if (scoreFirstPlaeyr < scoreSecondPlaeyr)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", scoreSecondPlaeyr);
            Console.WriteLine("Games won: {0}", countWinSecond);
        }
        else if (scoreFirstPlaeyr == scoreSecondPlaeyr)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", scoreSecondPlaeyr);
        }


    }
}