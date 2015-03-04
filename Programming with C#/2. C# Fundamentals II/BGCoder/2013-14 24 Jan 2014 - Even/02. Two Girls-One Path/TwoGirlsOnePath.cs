using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Two_Girls_One_Path
{
    class TwoGirlsOnePath
    {
        static void Main()
        {
            var num = ReadInput();

            int mollyIndex = 0;
            int dollyIndex = num.Length - 1;

            BigInteger mollyTotalFlowers = 0;
            BigInteger dollyTotalFlowers = 0;

            string winner = string.Empty;

            while (true)
            {
                if (num[mollyIndex] == 0 || num[dollyIndex] == 0)
                {
                    if (num[mollyIndex] == 0 && num[dollyIndex] == 0)
                    {
                        winner = "Draw";
                    }
                    else if (num[mollyIndex] == 0)
                    {
                        winner = "Dolly";
                    }
                    else if (num[dollyIndex] == 0)
                    {
                        winner = "Molly";
                    }

                    mollyTotalFlowers += num[mollyIndex];
                    dollyTotalFlowers += num[dollyIndex];
                    break;
                }

                BigInteger currMollyFlowers = num[mollyIndex];
                BigInteger currDollyFlowers = num[dollyIndex];


                num[mollyIndex] = 0;
                num[dollyIndex] = 0;

                mollyTotalFlowers += currMollyFlowers;
                dollyTotalFlowers += currDollyFlowers;


                mollyIndex = (int) ((mollyIndex + currMollyFlowers) % num.Length);
                dollyIndex = (int) ((dollyIndex - currDollyFlowers) % num.Length);

                if (dollyIndex < 0)
                {
                    dollyIndex += num.Length;
                }

            }

            Console.WriteLine(winner);
            Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);

        }

        private static int[] ReadInput()
        {
            int[] number = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            return number;
        }
    }
}
