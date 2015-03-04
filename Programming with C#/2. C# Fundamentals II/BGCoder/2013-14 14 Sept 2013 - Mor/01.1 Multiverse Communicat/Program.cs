using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1_Multiverse_Communicat
{
    class Program
    {
        const int baseSystem = 13;
        static void Main()
        {
            string text = Console.ReadLine();

            var arr = new string[] { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

            ulong result = 0;

            for (int i = 0; i < text.Length; i += 3)
            {
                string currText = text.Substring(i, 3);

                //for (int j = 0; j < arr.Length; j++)
                //{
                //    if (currNumber == arr[j])
                //    {
                //        result *= (ulong)baseSystem;
                //        result += (ulong)j;
                //    }
                //}

                int currNumber = Array.IndexOf(arr, currText);

                result *= (ulong)baseSystem;
                result += (ulong)currNumber;
            }

            Console.WriteLine(result);  
        }
    }
}
