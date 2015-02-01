using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.The_Horror
{
    class TheHorror
    {
        static void Main()
        {
            string input = Console.ReadLine();

            long result = 0;
            int countEventDigit = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0 && Char.IsDigit(input[i]))
                {
                    result+= input[i] -'0';
                    countEventDigit++;
                }
            }

            Console.Write("{0} ", countEventDigit);
            Console.WriteLine(result);
        }
    }
}
