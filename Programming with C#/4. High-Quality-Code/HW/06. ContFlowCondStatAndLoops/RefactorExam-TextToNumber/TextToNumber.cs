namespace RefactorExam_TextToNumber
{
    using System;
    using System.Numerics;

    public class TextToNumber
    {
        public static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string inputUpper = input.ToUpper();

            BigInteger result = 0;

            for (int i = 0; i < inputUpper.Length; i++)
            {
                char symbol = inputUpper[i];

                if (symbol != '@')
                {
                    if (char.IsDigit(symbol))
                    {
                        result *= (BigInteger)(symbol - '0');
                    }
                    else if (symbol - 'A' >= 0 && symbol - 'A' < 26)
                    {
                        result += symbol - 'A';
                    }
                    else
                    {
                        result %= number;
                    }
                }
                else
                {
                    Console.WriteLine(result);
                    break;
                }
            }
        }
    }
}
