using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StrangeLand_Numbers
{
    class StrangeLandNumbers
    {
        static ulong baseSystem = 7;

        private static ulong GetPower(int power)
        {
            ulong result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= baseSystem;
            }

            return result;
        }

        static void Main()
        {
            string[] numberSevenSystem = new string[] { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };

            string input = Console.ReadLine();

            ulong result = 0;

            int position = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == 'f')
                {
                    result += 0 * GetPower(position);
                    position++;
                 
                }
                else if (input[i] == 'b')
                {
                    result += 1 * GetPower(position);
                    position++;
                   
                }
                else if (input[i] == 'o')
                {
                    result += 2 * GetPower(position);
                    position++;
                    
                }
                else if (input[i] == 'm')
                {
                    result += 3 * GetPower(position);
                    position++;
                  
                }
                else if (input[i] == 'l')
                {
                    result += 4 * GetPower(position);
                    position++;
                    
                }
                else if (input[i] == 'p')
                {
                    result += 5 * GetPower(position);
                    position++;
                }
                else if (input[i] == 'h')
                {
                    result += 6 * GetPower(position);
                    position++;
                }
            }

            Console.WriteLine(result);
        }

        
    }
}
