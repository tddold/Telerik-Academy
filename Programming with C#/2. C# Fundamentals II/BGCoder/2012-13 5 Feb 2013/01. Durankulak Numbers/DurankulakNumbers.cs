﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Durankulak_Numbers
{
    class DurankulakNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int[] path = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();


            int pathCount = 1;
            int maxPath = 1;

            for (int startIndex = 0; startIndex < path.Length; startIndex++)
            {
                int currIndex = startIndex;
                int nextIndex = currIndex;

                for (int step = 1; step < path.Length; step++)
                {
                    nextIndex = (currIndex + step) % path.Length;

                    while (path[currIndex] < path[nextIndex])
                    {
                        pathCount++;
                        currIndex = nextIndex;

                        nextIndex = (currIndex + step) % path.Length;

                        if (maxPath < pathCount)
                        {
                            maxPath = pathCount;
                        }
                    }

                    pathCount = 1;
                    currIndex = startIndex;
                }
            }

            Console.WriteLine(maxPath);
        }
    }
}
