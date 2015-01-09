using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fire
{
    class Fire
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string dotsOut = new string('.', (n - 2) / 2);
            string symbol = "#";

            Console.WriteLine(dotsOut + symbol + symbol + dotsOut);

            string dotsIn; //  = new string('.', 2);
            for (int i = 0; i < (n - 2) / 2; i++)
            {
                dotsOut = new string('.', ((n - 2) / 2 - 1) - i);
                dotsIn = new string('.', 2 + 2 * i);
                Console.WriteLine(dotsOut + symbol + dotsIn + symbol + dotsOut);
            }

            for (int i = 0; i < n / 4; i++)
            {
                dotsOut = new string('.', i);
                dotsIn = new string('.', (n-2)  - (2* i));
                Console.WriteLine(dotsOut + symbol + dotsIn + symbol + dotsOut);
            }

            string dahs = new string('-', n);
            Console.WriteLine(dahs);

            // string slash = "/";
            // string backslash = "\\";

            for (int i = 0; i < n / 2; i++)
            {
                dotsOut = new string('.', i);
                string backslash = new string('\\', n / 2 - i);
                string slash = new string('/', n/ 2 -i);
                Console.WriteLine(dotsOut +  backslash + slash + dotsOut);
            }
        }
    }
}
