using System;

class Poker01
{
    static void Main()
    {
        int cJ = 0;
        int cQ = 0;
        int cK = 0;
        int cA = 0;
        int c2 = 0;
        int c3 = 0;
        int c4 = 0;
        int c5 = 0;
        int c6 = 0;
        int c7 = 0;
        int c8 = 0;
        int c9 = 0;
        int c10 = 0;

        for (int i = 0; i < 5; i++)
        {
            string input = Console.ReadLine();

            if (input == "2")
            {
                c2++;
            }
            else if (input == "3")
            {
                c3++;
            }
            else if (input == "4")
            {
                c4++;
            }
            else if (input == "5")
            {
                c5++;
            }
            else if (input == "6")
            {
                c6++;
            }
            else if (input == "7")
            {
                c7++;
            }
            else if (input == "8")
            {
                c8++;
            }
            else if (input == "9")
            {
                c9++;
            }
            else if (input == "10")
            {
                c10++;
            }
            else if (input == "J")
            {
                cJ++;
            }
            else if (input == "Q")
            {
                cQ++;
            }
            else if (input == "K")
            {
                cK++;
            }
            else if (input == "A")
            {
                cA++;
            }
        }


        if (c2 == 5 || c3 == 5 || c4 == 5 || c5 == 5 || c6 == 5 || c7 == 5 || c8 == 5 ||
            c9 == 5 || c10 == 5 || cJ == 5 || cQ == 5 || cK == 5 || cA == 5)
        {
            Console.WriteLine("Impossible");
        }
        else if (c2 == 4 || c3 == 4 || c4 == 4 || c5 == 4 || c6 == 4 || c7 == 4 || c8 == 4 ||
                  c9 == 4 || c10 == 4 || cJ == 4 || cQ == 4 || cK == 4 || cA == 4)
        {
            Console.WriteLine("Four of a Kind");
        }
        else if ((c2 == 3 || c3 == 3 || c4 == 3 || c5 == 3 || c6 == 3 || c7 == 3 || c8 == 3 ||
                  c9 == 3 || c10 == 3 || cJ == 3 || cQ == 3 || cK == 3 || cA == 3) &&
                 (c2 == 2 || c3 == 2 || c4 == 2 || c5 == 2 || c6 == 2 || c7 == 2 || c8 == 2 ||
                  c9 == 2 || c10 == 2 || cJ == 2 || cQ == 2 || cK == 2 || cA == 2))
        {
            Console.WriteLine("Full House");
        }
        else if ((cA == 1 && c2 == 1 && c3 == 1 && c4 == 1 && c5 == 1) ||
                 (c2 == 1 && c3 == 1 && c4 == 1 && c5 == 1 && c6 == 1) ||
                 (c3 == 1 && c4 == 1 && c5 == 1 && c6 == 1 && c7 == 1) ||
                 (c4 == 1 && c5 == 1 && c6 == 1 && c7 == 1 && c8 == 1) ||
                 (c5 == 1 && c6 == 1 && c7 == 1 && c8 == 1 && c9 == 1) ||
                 (c6 == 1 && c7 == 1 && c8 == 1 && c9 == 1 && c10 == 1) ||
                 (c7 == 1 && c8 == 1 && c9 == 1 && c10 == 1 && cJ == 1) ||
                 (c8 == 1 && c9 == 1 && c10 == 1 && cJ == 1 && cQ == 1) ||
                 (c9 == 1 && c10 == 1 && cJ == 1 && cQ == 1 && cK == 1) ||
                 (c10 == 1 && cJ == 1 && cQ == 1 && cK == 1 && cA == 1))
        {
            Console.WriteLine("Straight");
        }
        else if (c2 == 3 || c3 == 3 || c4 == 3 || c5 == 3 || c6 == 3 || c7 == 3 || c8 == 3 ||
                 c9 == 3 || c10 == 3 || cJ == 3 || cQ == 3 || cK == 3 || cA == 3)
        {
            Console.WriteLine("Three of a Kind");
        }
        else if ((c2 == 2 || c3 == 2 || c4 == 2 || c5 == 2 || c6 == 2 || c7 == 2 || c8 == 2 ||
                  c9 == 2 || c10 == 2 || cJ == 2 || cQ == 2 || cK == 2 || cA == 2) &&
                 (c2 == 2 || c3 == 2 || c4 == 2 || c5 == 2 || c6 == 2 || c7 == 2 || c8 == 2 ||
                  c9 == 2 || c10 == 2 || cJ == 2 || cQ == 2 || cK == 2 || cA == 2))
        {
            Console.WriteLine("Two Pairs");
        }
        else if (c2 == 2 || c3 == 2 || c4 == 2 || c5 == 2 || c6 == 2 || c7 == 2 || c8 == 2 ||
                 c9 == 2 || c10 == 2 || cJ == 2 || cQ == 2 || cK == 2 || cA == 2)
        {
            Console.WriteLine("One Pair");
        }
        else
        {
            Console.WriteLine("Nothing");
        }

    }
}