using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1_Zerg
{
    class Zerg
    {
        const int baseSystem = 15;
        static void Main()
        {
            string text = Console.ReadLine();

            var arr = new List<string> { "Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh" };

            ulong result = 0;

            for (int i = 0; i < text.Length; i+=4)
            {
                var currText = text.Substring(i, 4);

                var currNumber = arr.IndexOf(currText);

                result *= (ulong)baseSystem;
                result += (ulong)currNumber;
            }

            Console.WriteLine(result);
        }
    }
}
