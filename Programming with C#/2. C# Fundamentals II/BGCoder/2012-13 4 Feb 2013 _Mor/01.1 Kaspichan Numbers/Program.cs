using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1_Kaspichan_Numbers
{
    class Program
    {
        static int baseSystem = 256;
        static void Main()
        {
            // input
            ulong number = ulong.Parse(Console.ReadLine());

            // get 256 system
            var arr = GetNumberToBaseSystem();

            // calculate
            string result = string.Empty;

            if (number == 0)
            {
                result = "A";
            }
            else
            {
                while (number > 0)
                {
                    int index = (int)(number % (ulong)baseSystem);

                    result = arr[index] + result;

                    number = number / (ulong)baseSystem;
                }
            }

            // output
            Console.WriteLine(result);
        }

        static string[] GetNumberToBaseSystem()
        {
            var arr = new string[baseSystem];

            for (int i = 0; i < baseSystem; i++)
            {
                if (i < 26)
                {
                    arr[i] = string.Format("{0}", ((char)(i % 26 + 'A')).ToString());
                }
                else
                {
                    arr[i] = string.Format("{0}{1}", ((char)(i / 26 - 1 + 'a')).ToString(), ((char)(i % 26 + 'A')).ToString());
                }
            }

            return arr;
        }
    }
}
