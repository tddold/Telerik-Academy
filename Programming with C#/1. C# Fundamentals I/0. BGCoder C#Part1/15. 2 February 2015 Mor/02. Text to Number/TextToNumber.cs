using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

namespace _02.Text_to_Number
{
    class TextToNumber
    {
        static void Main()
        {

            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);

            BigInteger m = BigInteger.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            string inputUpper = input.ToUpper();

            BigInteger result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol != '@')
                {
                    if (Char.IsDigit((symbol)))
                    {
                        result *= (BigInteger) (symbol - '0');
                    }
                    else if (symbol - 'A' >= 0 && symbol - 'A' < 26)
                    {
                        result += symbol - 'A';


                    }
                    else if (symbol - 'a' >= 0 && symbol - 'a' < 27)
                    {
                        result += symbol - 'a';
                    }
                    else
                    {
                        result %= m;
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
