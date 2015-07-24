namespace Math_Problem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MathProblem
    {
        private static ulong baseSystem = 19;

        public static void Main()
        {
            // arr 19 base system
            char[] arrayOfChars = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's' };

            // read input
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // logic
            StringBuilder numberInNineteenNumericSystem = new StringBuilder();
            ulong number = ConvertInputToNumber(arrayOfChars, input);
            ulong result = CalculateResult(arrayOfChars, numberInNineteenNumericSystem, number);

            // output
            Console.WriteLine("{0} = {1}", numberInNineteenNumericSystem, result);
        }

        /// <summary>
        /// Method that calculates decimal number system in nineteen number system.
        /// </summary>
        /// <param name="arrayOfChars">Input symbols.</param>
        /// <param name="numberInNineteenNumericSystem">String in nineteen number system.</param>
        /// <param name="number">Converts number.</param>
        /// <returns>Integer number.</returns>
        private static ulong CalculateResult(char[] arrayOfChars, StringBuilder numberInNineteenNumericSystem,  ulong number)
        {
            ulong result = number;

            if (number == 0)
            {
                result = 'a';
            }
            else
            {
                while (number > 0)
                {
                    int digits = (int)(number % baseSystem);
                    numberInNineteenNumericSystem.Insert(0, arrayOfChars[digits]);
                    number /= baseSystem;
                }
            }

            return result;
        }        

        /// <summary>
        /// Method that calculates input to number.
        /// </summary>
        /// <param name="arrayOfChars">All chars.</param>
        /// <param name="input">Input.</param>
        /// <returns>Number.</returns>
        private static ulong ConvertInputToNumber(char[] arrayOfChars, string[] input)
        {
            ulong number = 0;
            ulong subResult = 0;

            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    int pow = word.Length - 1 - i;
                    int currNumber = Array.IndexOf(arrayOfChars, word[i]);
                    subResult += (ulong)currNumber * Power(pow);
                }

                number += subResult;
                subResult = 0;
            }

            return number;
        }

        private static ulong Power(int pow)
        {
            ulong result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= baseSystem;
            }

            return result;
        }
    }
}
