using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2__Astrological_Digits
{
    class AstrologicalDigits
    {
        static void Main(string[] args)
        {
            
            string inputLine = Regex.Replace(Console.ReadLine(), "[.-]", "");
            BigInteger number = BigInteger.Parse(inputLine);

            int result = (int)(1 + (BigInteger)((number) - 1) % 9);  // BigInteger.Remainder(number - 1, 9));
            Console.WriteLine(result);            
        }
    }
}
