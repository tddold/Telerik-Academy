using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    class Program
    {
        static void Main()
        {
            checked
            {
                int result = 17;
                result = result * 23 + 10000.GetHashCode();
                Console.WriteLine(result);
            }
        }
    }
}
