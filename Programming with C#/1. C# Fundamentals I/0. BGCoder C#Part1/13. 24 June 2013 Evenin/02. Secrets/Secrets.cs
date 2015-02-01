using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

namespace _02.Secrets
{
    class Secrets
    {
        static void Main()
        {
            //StreamReader reader = new StreamReader("..\\..\\input.txt");
            //Console.SetIn(reader);

            BigInteger n = BigInteger.Parse(Console.ReadLine());

            if (n < 0)
            {
                n *= -1;
            }

            BigInteger number = n;
            BigInteger specialSum = 0;
            int count = 1;

            while (number > 0)
            {
                int digits = (int) (number % 10);
                number /= 10;

                if (count % 2 == 0)
                {
                    specialSum += count * digits * digits;
                }
                else
                {
                    specialSum += count * count * digits;
                }

                count++;
            }

            int lastDigits = (int) (specialSum % 10);
            int index = (int) (specialSum % 26);

            Console.WriteLine(specialSum);

            if (lastDigits == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", n);
            }
            else
            {

                for (int i = 0; i < lastDigits; i++)
                {
                    Console.Write((char) ('A' + (index + i) % 26));
                }

                Console.WriteLine();
            }
        }
    }
}
