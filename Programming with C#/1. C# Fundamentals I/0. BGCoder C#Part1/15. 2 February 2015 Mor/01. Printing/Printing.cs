using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Printing
{
    class Printing
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal s = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());

            decimal sheet = 500;

            decimal totalSheet = (n * s) / sheet;

            decimal result = totalSheet * p;

            Console.WriteLine("{0:F2}", result);
        }
    }
}
