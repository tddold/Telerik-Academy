using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Kaspichan_Numbers
{
    class KaspichanNumbers
    {
        static void Main()
        {
            // array 256 - work to numBase = 700
            ulong numBase = 256;
            string[] arr = GenerateNumberArray(numBase);

            // read input

            ulong input = ulong.Parse(Console.ReadLine());


            // calculate
            string result = string.Empty;

            if (input == 0)
            {
                result = "A";
            }
            while (input > 0)
            {
                ulong index = input % numBase;
                result = arr[index] + result;
                input /= numBase;
            }


            // output

            Console.WriteLine(result);
        }

        private static string[] GenerateNumberArray(ulong numBase)
        {
            string[] arr = new string[numBase];

            for (int i = 0; i < (int) numBase; i++)
            {
                if (i < 26)
                {
                    arr[i] = ((char) (i % 26 + 'A')).ToString();
                }
                else
                {
                    arr[i] = string.Format("{0}{1}",
                        ((char) ((i / 26 - 1) + 'a')),
                        (char) (i % 26 + 'A'));
                }
            }

            return arr;
        }
    }
}
