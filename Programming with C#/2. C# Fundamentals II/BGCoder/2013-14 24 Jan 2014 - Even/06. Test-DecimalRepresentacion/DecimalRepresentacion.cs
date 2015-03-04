using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Test_DecimalRepresentacion
{
    class DecimalRepresentacion
    {
        static void Main()
        {
            var hex = "FAB1";
            var decimalRepresentacion = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                decimalRepresentacion *= 16;

                if (hex[i] >= '0' && hex[i] <= '9')
                {
                    decimalRepresentacion += hex[i] - '0';
                }
                else
                {
                    decimalRepresentacion += hex[i] +10 - 'A';
                }
            }

            Console.WriteLine(decimalRepresentacion);
        }
    }
}
