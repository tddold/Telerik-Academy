using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Peace_of_Cake
{
    class PeaceOfCake
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());

            long nominator = (a * d) + (b * c);
            long denominator = b * d;

            if (nominator >= denominator)
            {
                long resultInteger = nominator / denominator;

                Console.WriteLine(resultInteger);
                Console.WriteLine("{0}/{1}", nominator, denominator);
            }
            else
            {
                decimal resultDouble = nominator / (decimal) denominator;

                Console.WriteLine("{0:f22}", resultDouble);
                Console.WriteLine("{0}/{1}", nominator, denominator);
            }
        }
    }
}
