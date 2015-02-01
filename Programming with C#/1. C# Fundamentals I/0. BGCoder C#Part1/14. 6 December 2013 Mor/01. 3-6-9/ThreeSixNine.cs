using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3_6_9
{
    class ThreeSixNine
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());

            long result = 0;

            switch (b)
            {
                case 3:
                    result = a + c;
                    break;
                case 6:
                    result = a * c;
                    break;
                case 9:
                    result = a % c;
                    break;
            }

            if (result % 3 == 0)
            {                
                Console.WriteLine(result / 3);
            }
            else
            {
                Console.WriteLine(result % 3);

            }

            Console.WriteLine(result);
        }
    }
}
