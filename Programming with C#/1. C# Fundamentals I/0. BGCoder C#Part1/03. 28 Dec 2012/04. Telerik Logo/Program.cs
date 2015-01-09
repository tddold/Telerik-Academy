using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telerik_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string dotsOut = new string('.', x / 2);
            string dotsBetween;
            string dotsIn = new string('.', ((2 * x) - 3));
            Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut);

            for (int i = 1; i <= x / 2; i++)
            {
                dotsOut = new string('.', (x / 2) - i);
                dotsBetween = new string('.', 2 * i - 1);
                dotsIn = new string('.', ((2 * x) - 3) - 2 * i);

                Console.WriteLine(dotsOut + "*" + dotsBetween + "*" + dotsIn + "*" + dotsBetween + "*" + dotsOut);
            }

            for (int i = 1; i <= x / 2 - 1; i++)
            {
                dotsOut = new string('.', x - 1 + i);
                dotsIn = new string('.', x - 2 - 2 * i);
                Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut);
            }

            dotsOut = new string('.', (2 * x) - (x / 2 + 2));
            Console.WriteLine(dotsOut + "*" + dotsOut);

            for (int i = 1; i <= x - 1; i++)
            {
                dotsOut = new string('.', (2 * x) - (x / 2 + 2) - i);
                dotsIn = new string('.', ((x / 2 + 2 * i) - (x / 2 + 1)));
                Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut);
            }

            for (int i = 1; i < x - 1; i++)
            {
                dotsOut = new string('.', x / 2 + i);
                dotsIn = new string('.', ((2 * x) - 3) - 2 * i);
                Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut);
            }

            dotsOut = new string('.', (2 * x) - (x / 2 + 2));
            Console.WriteLine(dotsOut + "*" + dotsOut);
        }
    }
}
