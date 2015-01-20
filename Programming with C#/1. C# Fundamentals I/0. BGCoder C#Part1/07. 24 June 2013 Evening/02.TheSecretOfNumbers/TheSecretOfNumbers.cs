using System;

class TheSecretOfNumbers
{
    static void Main()
    {
        string n = Console.ReadLine();
        char[] removeSymbols = new char[] { '-' };
        n = n.TrimStart(removeSymbols);
       
        long secretSum = 0;
        long eventSecretSum = 0;
        long oddSecretSum = 0;

        for (int i = 0; i < n.Length; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                eventSecretSum += ((long.Parse(n[(n.Length - 1) - i].ToString()) * long.Parse(n[(n.Length - 1) - i].ToString())) * (i + 1));
            }
            else
            {
                oddSecretSum += (long.Parse(n[(n.Length - 1) - i].ToString()) * ((i + 1) * (i + 1)));
            }
        }

        secretSum = eventSecretSum + oddSecretSum;

        long checklastDigits = secretSum % 10;
        long remainder = 0;
        string secretAlphaSequence = String.Empty;
        if (checklastDigits == 0)
        {
            Console.WriteLine(secretSum);
            Console.WriteLine("{0} has no secret alpha-sequence", n);
        }
        else
        {
            remainder = secretSum % 26;
            string alphaBet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < checklastDigits; i++)
            {
                while (remainder > 25)
                {
                    remainder -= 26;
                }

                int index = (int) remainder;
                secretAlphaSequence += alphaBet[index];
                remainder++;
            }

            Console.WriteLine(secretSum);
            Console.WriteLine(secretAlphaSequence);
        }
    }
}