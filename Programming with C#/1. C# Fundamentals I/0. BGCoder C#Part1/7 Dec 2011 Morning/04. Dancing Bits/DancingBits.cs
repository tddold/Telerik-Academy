using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Dancing_Bits
{
    class DancingBits
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int result = 0;
            int counter = 0;
            int input = 0;
            string binaryNumber = "";

            for (int i = 0; i < n; i++)
            {
                input = int.Parse(Console.ReadLine());
                binaryNumber += Convert.ToString(input, 2).ToString();
            }

            Console.WriteLine(binaryNumber);

            for (int i = 0; i < binaryNumber.Length - k; i++)
            {
                for (int j = i + 1; j <= i + k; j++)
                {
                    if (binaryNumber[i] == binaryNumber[j])
                    {
                        counter++;
                    }
                }

                if (counter == k - 1)
                {
                    result++;
                    i = i + k;
                }

                counter = 0;
            }

            if (k == 1 && n != 1 && input != 1)
            {
                result += result;

            }
            else if (k == 1 && n == 1 && input != 1)
            {
                result = binaryNumber.Length;
            }
            else if (k == 1 && n == 1 && input == 1)
            {
                result = 1;
            }

            if (k == 1 && n != 1 && binaryNumber.Length > 31)
            {
                result = binaryNumber.Length;
            }
           
            Console.WriteLine(result);
        }
    }
}
