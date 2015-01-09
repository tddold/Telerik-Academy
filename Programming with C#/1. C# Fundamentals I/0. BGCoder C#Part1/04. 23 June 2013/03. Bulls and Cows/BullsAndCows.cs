using System;
using System.Collections.Generic;

class BullsAndCows
{
    static void Main()
    {
        string secretNumber = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        char usedGuestNumber = '*';
        char usedSecretNumber = '@';

        

        List<int> result = new List<int>();

        for (int num = 1000; num <= 9999; num++)
        {
            int countBulls = 0;
            int countCows = 0;

            char[] secretDigits = secretNumber.ToString().ToCharArray();
            char[] guestDigits = num.ToString().ToCharArray();
            if (guestDigits[0] >= '1' && guestDigits[1] >= '1' && guestDigits[2] >= '1' && guestDigits[3] >= '1')
            {
                // Found Bulls
                for (int i = 0; i < guestDigits.Length; i++)
                {
                    if (guestDigits[i] == secretDigits[i])
                    {
                        countBulls++;
                        guestDigits[i] = usedGuestNumber;
                        secretDigits[i] = usedSecretNumber;
                    }
                }

                // Founds Cows
                for (int i = 0; i < guestDigits.Length; i++)
                {
                    for (int j = 0; j < guestDigits.Length; j++)
                    {
                        if (guestDigits[i] == secretDigits[j])
                        {
                            countCows++;
                            guestDigits[i] = usedGuestNumber;
                            secretDigits[j] = usedSecretNumber;
                        }
                    }
                    
                }

                if (countBulls == bulls && countCows == cows)
                {
                    result.Add(num);
                }

            }
        }

        if (result.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            foreach (var num in result)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }
}