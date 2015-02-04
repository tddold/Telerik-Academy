using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Saddy_Kopper
{
    class SaddyKopper
    {
        static void Main()
        {
            string number = Console.ReadLine();

            BigInteger result = 1;
            BigInteger sum = 0;

            string newNumber = String.Empty;
            bool isOneDigits = false;
            int count = 0;

            while (!isOneDigits)
            {
                for (int i = 0; i < number.Length; i++) // !!!!!!!!!!!!!!!!!!!!!
                {


                    number = number.Remove(number.Length - 1);
                    sum = 0;
                    for (int j = 0; j < number.Length; j++)
                    {
                        if (j % 2 == 0)
                        {
                            sum += BigInteger.Parse(number[j].ToString());
                        }
                    }

                    result *= (long) sum;
                    i = 0;

                }

                count++;

                if (count < 10)
                {
                    number = result.ToString();
                    if (number.Length == 1)
                    {
                        isOneDigits = true;
                    }
                    else
                    {
                        result = 1;
                    }
                }
                else if (count == 10)
                {
                    isOneDigits = true;
                    break;
                }

            }

            if (count < 10)
            {
                Console.WriteLine(count);
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine(result);
            }           
        }
    }
}
