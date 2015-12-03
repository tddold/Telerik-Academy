using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesRequrent
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            var answer = PalceTrees(a, b, c, d, -1);
            Console.WriteLine(answer);
        }

        static long PalceTrees(int a, int b, int c, int d, int lastType)
        {
            if (a+b+c+d == 0)
            {
                return 1;
            }

            long count = 0;

            if (a > 0 && lastType != 0)
            {
                count += PalceTrees(a - 1, b, c, d, 0);
            }

            if (b > 0 && lastType != 1)
            {
                count += PalceTrees(a, b - 1, c, d, 1);
            }

            if (c > 0 && lastType != 2)
            {
                count += PalceTrees(a, b, c - 1, d, 2);
            }

            if (d > 0 && lastType != 3)
            {
                count += PalceTrees(a, b, c, d - 1, 3);
            }

            return count;
        }
    }
}
