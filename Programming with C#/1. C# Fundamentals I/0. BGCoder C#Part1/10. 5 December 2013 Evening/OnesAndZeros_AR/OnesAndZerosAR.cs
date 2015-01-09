using System;
using System.Collections.Generic;

class OnesAndZerosAR
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < 5; row++)
        {
            for (int bit = 15; bit >= 0; bit--)
            {
                int bitNumber = (1 << bit) & n;
                bitNumber = bitNumber >> bit;

                if (bitNumber == 1)
                {
                    switch (row)
                    {
                        case 0:
                        case 2:
                        case 3:
                            Console.Write(".#.");
                            break;
                        case 1:
                            Console.Write("##.");
                            break;
                        case 4:
                            Console.Write("###");
                            break;
                        default:
                            break;
                    }

                    if (bit != 0)
                    {
                        Console.Write(".");
                    }
                }
                else
                {
                    switch (row)
                    {
                        case 0:
                        case 4:
                            Console.Write("###");
                            break;
                        case 1:
                        case 2:
                        case 3:
                            Console.Write("#.#");
                            break;
                        default:
                            break;
                    }

                    if (bit != 0)
                    {
                        Console.Write(".");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}