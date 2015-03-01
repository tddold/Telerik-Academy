using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Testing
{
    class Test
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(new char[]{',', ' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
        }
    }
}
