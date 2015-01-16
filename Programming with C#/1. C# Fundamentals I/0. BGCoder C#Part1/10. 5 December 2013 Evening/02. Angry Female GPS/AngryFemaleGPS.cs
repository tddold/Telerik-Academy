using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Angry_Female_GPS
{
    class AngryFemaleGPS
    {
        static void Main()
        {
            // input
            string n = Console.ReadLine();

            // solution
            long sumEven = 0;
            long sumOdd = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '-')
                {
                    continue;
                }
                if (((long) n[i] -48) % 2 == 0)
                {
                    sumEven += (long) n[i] - 48;
                }
                else
                {
                    sumOdd += (long) n[i]-48;
                }
            }

            // print result
            if (sumOdd == sumEven)
            {
                Console.WriteLine("straight {0}", sumOdd);
            }
            else if (sumOdd > sumEven)
            {
                Console.WriteLine("left {0}", sumOdd);
            }
            else
            {
                Console.WriteLine("right {0}", sumEven);
            }
        }
    }
}
