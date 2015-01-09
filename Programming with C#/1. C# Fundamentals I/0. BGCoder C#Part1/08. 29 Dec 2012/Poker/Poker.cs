using System;
using System.Collections.Generic;

// http://bgcoder.com/Contests/Practice/Index/43#2
class Poker
{
    static void Main()
    {
        const int n = 5;
        const int ten = 10;
        const int J = 63;
        const int Q = 69;
        const int K = 62;
        const int A = 51;

        string input = String.Empty;

        for (int i = 0; i < n; i++)
        {
            input += Console.ReadLine();
        }

        List<int> cards = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 'J')
            {
                cards.Add(input[i] - J);
            }
            else if (input[i] == 'Q')
            {
                cards.Add(input[i] - Q);
            }
            else if (input[i] == 'K')
            {
                cards.Add(input[i] - K);
            }
            else if (input[i] == 'A')
            {
                cards.Add(input[i] - A);
            }
            else if (input[i] == '1' && input[i+1] == '0')
            {
                cards.Add(ten);
            }
            else if (input[i] != '1' && input[i] != '0')
            {
                cards.Add(input[i] - 48);
            }
        }

        cards.Sort();

        List<int> equalSequence = new List<int>();

        int count = 1;
        int countSequece = 1;
        int startCount = 0;
        string result = String.Empty;
        for (int i = 0; i < cards.Count; i++)
        {
            if (startCount <= i)
            {
                startCount = i + 1;
            }

            count = 1;
            for (int j = startCount; j < cards.Count; j++)
            {
                if (cards[i] == cards[j])
                {
                    count++;
                    startCount++;

                }
                else if (cards[i] == cards[j] - 1)
                {
                    countSequece++;

                    if (countSequece == 5)
                    {
                        break;
                    }
                }
            }

            if (count >= 4)
            {
                break;
            }

            if (count > 1 && count < 4)
            {
                equalSequence.Add(count);
            }
        }

        if (count >= 4)
        {
            result = "Impossible";
        }
        else if (countSequece == 5)
        {
            result = "Straight";
        }
        else if (cards[0] == 2 && cards[1] == 3 && cards[2] == 4 && cards[3] == 5 && cards[4] == 14)
        {
            result = "Straight";
        }
        else if (equalSequence.Count == 1)
        {
            if (equalSequence[0] == 4)
            {
                result = "Four of a Kind";
            }
            else if (equalSequence[0] == 3)
            {
                result = "Three of a Kind";
            }
            else if (equalSequence[0] == 2)
            {
                result = "One Pair";
            }
        }
        else if (equalSequence.Count == 2)
        {
            if (equalSequence[0] == 2 && equalSequence[1] == 2)
            {
                result = "Two Pairs";
            }
            else if ((equalSequence[0] == 2 && equalSequence[1] == 3) || (equalSequence[0] == 3 && equalSequence[1] == 2))
            {
                result = "Full House";
            }
        }
        else
        {
            result = "Nothing";
        }

        Console.WriteLine(result);
    }
}