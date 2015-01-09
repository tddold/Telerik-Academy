using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Coffee_Vending_Machine
{
    class CoffeeVendingMachine
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            decimal a = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());

            // Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", n1, n2, n3, n4, n5, a, p);

            decimal sumCoindN1 = n1 * 0.05m;
            decimal sumCoindN2 = n2 * 0.1m;
            decimal sumCoindN3 = n3 * 0.2m;
            decimal sumCoindN4 = n4 * 0.5m;
            decimal sumCoindN5 = n5 * 1m;
            decimal totalSumCoins = sumCoindN1 + sumCoindN2 + sumCoindN3 + sumCoindN4 + sumCoindN5;

            // Console.WriteLine("{0} {1} {2} {3} {4} {5} ", sumCoindN1, sumCoindN2, sumCoindN3, sumCoindN4, sumCoindN5, totalSumCoins);
            decimal givenChange = a - p;

            if (givenChange <0)
            {
                Console.WriteLine("More {0}", (decimal)Math.Abs(givenChange));
            }
            else
            {
                if (givenChange < totalSumCoins || givenChange == 0)
                {
                    Console.WriteLine("Yes {0}", totalSumCoins - givenChange);
                }
                else
                {
                    Console.WriteLine("No {0}", givenChange - totalSumCoins);
                }
            }

        }
    }
}
