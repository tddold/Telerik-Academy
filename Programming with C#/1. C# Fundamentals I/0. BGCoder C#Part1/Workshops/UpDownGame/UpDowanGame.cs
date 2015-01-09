using System;

class UpDowanGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Up-Dowan Game");
        Console.WriteLine("Try to guess the number (from 1 to 100)");

        Random generatedNumber = new Random();

        //Console.WriteLine(generatedNumber.Next(1, 101));

        int endGameNumber = generatedNumber.Next(1, 101);
        int minmum = 1;
        int maximum = 100;

        while (true)
        {
            Console.Write("Enter number between {0} and {1}: ", minmum, maximum);

            string readNumberString = Console.ReadLine();

            int userNumber;

            bool parsedNumber = int.TryParse(readNumberString, out userNumber);

            // Check whether the input string is a number or text
            if (!parsedNumber)
            {
                Console.WriteLine("Invalid number!");
                continue;
            }

            // Checkthe input number over the minimum or maximum
            if (userNumber < minmum || userNumber > maximum)
            {
                Console.WriteLine("Number out of range!");
                continue;
            }

            if (userNumber == endGameNumber)
            {
                Console.WriteLine("Congratulations. You won!");
                break;
            }
            else if (userNumber > endGameNumber)
            {
                maximum = userNumber - 1;
                Console.WriteLine("DOWAN!!!");
            }
            else if (userNumber < endGameNumber)
            {
                minmum = userNumber + 1;
                Console.WriteLine("UP!!!");
            }
        }
    }
}