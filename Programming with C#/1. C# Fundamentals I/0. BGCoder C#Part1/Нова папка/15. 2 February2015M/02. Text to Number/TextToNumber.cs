using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

namespace _2.Text_to_Number
{
    class TextToNumber
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader("..\\..\\input.txt");
            //Console.SetIn(reader);

            BigInteger m = BigInteger.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            string inputUpper = input.ToUpper();

            BigInteger result = 1;

            for (int i = 0; i < inputUpper.Length; i++)
            {
                char symbol = inputUpper[i];

                if (symbol != '@')
                {
                    if (Char.IsDigit((symbol)))
                    {
                        result *= (BigInteger) (symbol - '0');
                        
                    }
                    else if (symbol - 'A' >= 0 && symbol - 'A' < 27)
                    {
                        result += symbol - 'A';


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