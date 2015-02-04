using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bits_to_Bits
{
    class BitsToBits
    {
        static void Main()
        {
            //StreamReader reader = new StreamReader("..\\..\\input.txt");
            //Console.SetIn(reader);

            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                string number = Convert.ToString(num, 2).PadLeft(30, '0');
                sb.Append(number);
            }

            // bool[] isChecket = new bool[sb.Length];
            int firstOneResult = 1;
            int secondOneResult = 1;
            int thirdOneResult = 1;
            int zeroResult = 0;
            int tmp = 0;
            // int countOne = 0;
            //  int countZero = 0;

            int currCountZero = 1;
            int currCountOne = 1;

            for (int j = 0; j < sb.Length - 1; j++)
            {
                if (sb[j] == '0')
                {
                    currCountOne = 1;

                    if (sb[j] == sb[j + 1])
                    {
                        currCountZero++;

                        if (zeroResult < currCountZero)
                        {
                            zeroResult = currCountZero;
                        }
                        // isChecket[j] = true;
                    }
                }
                else
                {
                    currCountZero = 1;

                    if (sb[j] == sb[j + 1])
                    {
                        currCountOne++;

                        if (firstOneResult < currCountOne)
                        {
                            firstOneResult = currCountOne;
                        }
                        else if (secondOneResult < currCountOne)
                        {
                            secondOneResult = currCountOne;
                        }
                        else if (thirdOneResult < currCountOne)
                        {
                            thirdOneResult = currCountOne;
                        }
                        // isChecket[j] = true;
                    }

                }
            }


            if (n == 1)
            {
                Console.WriteLine(zeroResult);
            }
            else // if (n == 2)
            {
                Console.WriteLine(zeroResult);
                Console.WriteLine(firstOneResult);
            }
            //else if (n == 3)
            //{
            //    Console.WriteLine(zeroResult);
            //    Console.WriteLine(firstOneResult);
            //    Console.WriteLine(secondOneResult);
            //}
            //else if (n > 3)
            //{
            //    Console.WriteLine(zeroResult);
            //    Console.WriteLine(firstOneResult);
            //    Console.WriteLine(secondOneResult);
            //    Console.WriteLine(thirdOneResult);
            //}
        }
    }
}
