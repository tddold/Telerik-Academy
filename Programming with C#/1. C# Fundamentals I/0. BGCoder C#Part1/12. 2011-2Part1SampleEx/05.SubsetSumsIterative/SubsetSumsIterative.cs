using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace _05.Subset_Sums
{
    class SubsetSums
    {
        static void Main()
        {
            if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
            {
                Console.SetIn(new StreamReader("input.txt"));
            }

            BigInteger sum = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            List<BigInteger> numbers = new List<BigInteger>();
            bool[] checkedIdnex = new bool[n];

            // input
            for (int i = 0; i < n; i++)
            {
                numbers.Add(BigInteger.Parse(Console.ReadLine()));
            }

            int countSum = 0;
            int count = 0;
            for (int l = 0; l < n; l++)
            {
                for (int i = l; i < n; i++)
                {

                    BigInteger oldSum = 0;
                    for (int j = l; j <= i; j++)
                    {
                        oldSum += numbers[j];
                    }

                    if (oldSum == sum)
                    {
                        countSum++;
                    }

                    for (int j = i + 1; j < n; j++)
                    {
                        BigInteger newSum = oldSum + numbers[j];
                        if (newSum == sum)
                        {
                            countSum++;
                        }

                    }
                }
            }



            // output
            // Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine(countSum);
        }
    }
}
