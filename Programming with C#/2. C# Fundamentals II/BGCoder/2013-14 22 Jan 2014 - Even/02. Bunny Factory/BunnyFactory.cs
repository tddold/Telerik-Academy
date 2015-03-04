using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Bunny_Factory
{
    class BunnyFactory
    {
        static void Main()
        {
            var nums =  ReadNumbers();

            BigInteger sum = 0;
            BigInteger product = 1;
            //int count = 1;
            

            List<int> result = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < nums.Count; i++)
            {
                int s = 0;
                for (int m = 0; m <= i; m++)
                {
                    s += nums[m];
                }                

                if (s < nums.Count)
                {
                    int count = 1;
                    int index = i + 1;
                    while (count <= s)
                    {

                        sum += nums[index];
                        count++;
                        index++;
                    }

                    for (int j = i + 1; j <= s+i; j++)
                    {
                        product *= nums[j];
                    }

                    sb.Append(sum);
                    sb.Append(product);
                    for (int k = s+ 1 + i; k < nums.Count; k++)
                    {
                        sb.Append(nums[k]);
                    }

                    for (int l = 0; l < sb.Length; l++)
                    {
                        if (sb[l] == '0' || sb[l] == '1')
                        {
                            sb.Remove(l, 1);
                            l--;
                        }
                    }

                    nums.Clear();
                    for (int n = 0; n < sb.Length; n++)
                    {
                        nums.Add(sb[n] - '0');
                    }

                    sum = 0;
                    product = 1;
                    sb.Clear();
                   
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", nums));


        }

        private static List<int> ReadNumbers()
        {
            var num = new List<int>();
            int number;

            while (true)
            {
                bool chesk = int.TryParse(Console.ReadLine(), out number);

                if (chesk)
                {
                    num.Add(number);
                }
                else
                {
                    break;
                }
            }

            return num;
        }
    }
}
