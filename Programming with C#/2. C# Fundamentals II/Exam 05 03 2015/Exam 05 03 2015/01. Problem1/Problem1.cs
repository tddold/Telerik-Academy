using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem1
{
    class Problem1
    {
        static ulong baseSystem = 19;

        static void Main()
        {
            // arr 19 base system
            char[] arr = new char[] 
            {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's'};

            // read input
            string[] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

            // calc
            StringBuilder number19th = new StringBuilder();
            ulong number10th = 0;
            ulong subResult = 0;

            foreach (var word in input)
            { 
                for (int i = 0; i < word.Length; i++)
                {
                    int pow = word.Length -1 - i;
                    int currNumber = Array.IndexOf(arr, word[i]);
                    subResult += (ulong)currNumber * Power(pow);
                    
                }

                number10th += subResult;
                subResult = 0;
            }

            ulong result = number10th;

            if (number10th == 0)
            {
                result = 'a';
            }
            else
            {
                while (number10th > 0)
                {
                    int digits = (int)(number10th % baseSystem);
                    number19th.Insert(0, arr[digits]);
                    number10th /= baseSystem;
                }
            }  

            // output
            Console.WriteLine("{0} = {1}", number19th, result);
        }

        private static ulong Power(int pow)
        {
            ulong result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= baseSystem;
            }

            return result;
        }

        
    }
}
