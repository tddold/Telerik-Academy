using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.A_nacci
{
    class ANacci
    {
        static void Main()
        {
            // A = 65
            // Z = 90
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            string alfaBet = "0ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int arrLenght = (2 * l);
            int[] array = new int[arrLenght];

            array[0] = first - 64;
            array[1] = second - 64;

            if (l == 1)
            {
                Console.WriteLine(alfaBet[array[0]]);
            }
            else
            {
                for (int i = 2; i < array.Length - 1; i++)
                {
                    int sum = 0;
                    sum = array[i - 1] + array[i - 2];
                    if (sum < 27)
                    {
                        array[i] = sum;
                    }
                    else
                    {
                        array[i] = sum % 26;
                    }
                }

                int count = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(alfaBet[array[i]]);
                    }
                    else if (i == 1 || i == 2)
                    {
                        Console.Write(alfaBet[array[i]]);
                        Console.Write("{0}\n", alfaBet[array[i + 1]]);
                        i++;
                    }
                    else if (i > 2)
                    {
                        Console.Write(alfaBet[array[i]]);
                        if (count <= l - 2)
                        {
                            count++;
                        }
                        int spase = 1;
                        while (spase <= count)
                        {
                            Console.Write(" ");
                            spase++;
                        }

                        Console.Write("{0}\n", alfaBet[array[i + 1]]);
                        i++;
                    }
                }
            }
        }
    }
}
