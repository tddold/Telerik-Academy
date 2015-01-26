using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05.SubsetSumsBit
{
    class SubsetSumsBit
    {
        static void Main(string[] args)
        {
            BigInteger s = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            BigInteger[] numbers = new BigInteger[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = BigInteger.Parse(Console.ReadLine());
            }

            int counter = 1;
            while (true)
            {
                string bits = Convert.ToString(counter, 2).PadLeft(n,'0');
                if (bits.Length > n)
                {
                    break;
                }

                BigInteger sum = 0;
                for (int i = 0; i < bits.Length; i++)
                {
                    if (bits[i] == '1')
                    {
                        sum += numbers[i];
                    }
                }

                if (sum == s)
                {
                    count++;
                }

                counter++;
            }

            Console.WriteLine(count);          
        }

    }
}
