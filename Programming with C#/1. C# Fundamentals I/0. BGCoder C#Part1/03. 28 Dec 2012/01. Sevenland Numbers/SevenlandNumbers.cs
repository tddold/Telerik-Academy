using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sevenland_Numbers
{
    class SevenlandNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = 0;
            result = n + 1;

            int singleOfNumber = result % 10;

            if (singleOfNumber > 6)
            {
                result = result + 10;
                singleOfNumber = 0;
            }

            int decimalOfNumber = (result % 100) / 10;

            if (decimalOfNumber > 6)
            {
                result = result + 100;
                decimalOfNumber = 0;
            }

            int hundredthOfNumber = result / 100;

            if (hundredthOfNumber > 6)
            {
                hundredthOfNumber = 10;
            }

            result = hundredthOfNumber * 100 + decimalOfNumber * 10 + singleOfNumber;

            Console.WriteLine(result);
        }
    }
}
