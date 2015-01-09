using System;
using System.Linq;
using System.Collections.Generic;

class Sheets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        const int a10 = 1;
        const int a9 = 2 * a10;
        const int a8 = 4 * a10;
        const int a7 = 8 * a10;
        const int a6 = 16 * a10;
        const int a5 = 32 * a10;
        const int a4 = 64 * a10;
        const int a3 = 128 * a10;
        const int a2 = 256 * a10;
        const int a1 = 512 * a10;
        const int a0 = 1024 * a10;

        int[] sheets = new int[] { a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 };

        List<int> resultIndex = new List<int>();

        int index = 10;
        while (index >= 0)
        {

            if (n == 0)
            {
                break;
            }

            if (n == sheets[index])
            {
                resultIndex.Add(sheets[index]);

                break;
            }

            if (n < sheets[index])
            {
                n -= sheets[index + 1];
                resultIndex.Add(sheets[index + 1]);
                index = 11;

            }

            if (n > sheets[0])
            {
                n -= sheets[0];
                resultIndex.Add(sheets[0]);
            }

            index--;
        }

        if (n == 0 || n == a0 || n == a1 || n == a2 || n == a3 || n == a4 ||
            n == a5 || n == a6 || n == a7 || n == a8 || n == a9 || n == a10)
        {
            for (int i = 0; i < sheets.Length; i++)
            {
                for (int j = 0; j < resultIndex.Count; j++)
                {
                    if (sheets[i] == resultIndex[j])
                    {
                        i++;
                    }
                }

                if (i <= 10)
                {
                    Console.WriteLine("A{0}", i);
                }                
            }
        }
        else
        {
            for (int i = 0; i < sheets.Length - 1; i++)
            {
                for (int j = 0; j < resultIndex.Count; j++)
                {
                    if (sheets[i] == resultIndex[j])
                    {
                        i++;
                    }
                }

                Console.WriteLine("A{0}", i);
            }
        }
    }
}