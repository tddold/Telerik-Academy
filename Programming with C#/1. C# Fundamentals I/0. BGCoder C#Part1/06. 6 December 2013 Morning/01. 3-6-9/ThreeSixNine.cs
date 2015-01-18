using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._3_6_9
{
    class ThreeSixNine
    {
        static void Main()
        {
            // input
            long numberA = int.Parse(Console.ReadLine());
            long numberB = int.Parse(Console.ReadLine());
            long numberC = int.Parse(Console.ReadLine());

            // logic
            long result = 0;
            long remander = 0;
            long divideNumber = 0;

            if (numberB == 3)
            {
                result = numberA + numberC;
                remander = result % 3;
                divideNumber = result / 3;
            }
            else if (numberB == 6)
            {
                result = numberA * numberC;
                remander = result % 3;
                divideNumber = result / 3;
            }
            else if (numberB == 9)
            {
                result = numberA % numberC;
                remander = result % 3;
                divideNumber = result / 3;
            }

            //print
            if (remander == 0)
            {
                Console.WriteLine("{0}", divideNumber);
                Console.WriteLine("{0}", result);
            }
            else
            {
                Console.WriteLine("{0}", divideNumber);
                Console.WriteLine("{0}", result);    
            }
        }
    }
}
