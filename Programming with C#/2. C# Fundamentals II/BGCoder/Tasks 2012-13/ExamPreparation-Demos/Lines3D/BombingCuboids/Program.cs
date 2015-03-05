using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
//        Console.SetIn(new StringReader(
//@"4 3 5
//AAAA AAAA AAAA AAAA AAAA
//AAAA AAAA AAAA AAAA AAAC
//ABAA AAAA AAAA AAAA AAAA
//3
//1 2 3 1
//0 0 0 2
//0 0 0 2
//"));
        // W H D
        // 0 1 3
        int[] whd = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToArray();
  
        char[, ,] cuboid = new char[whd[0], whd[1], whd[2]];

        for (int h = 0; h < whd[1]; ++h)
        {
            // AAAA AAAB BAAA AABA
            string[] layer = Console.ReadLine().Split(' ');
            // [AAAA] [AAAB] [BAAA] [AABA]

            for (int d = 0; d < whd[2]; ++d)
            {
                // AAAB
                string segment = layer[d];
                for (int w = 0; w < whd[0]; ++w)
                {
                    cuboid[w, h, d] = segment[w];
                }
            }
        }

        // 3
        int bombCount = int.Parse(Console.ReadLine());

        // w h d p
        // 0 0 2 5
        int[][] bombs = new int[bombCount][];
        for (int ii = 0; ii < bombCount; ++ii)
        {
            bombs[ii] = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
        }

        int allDestroyed = 0;
        int[] destroyed = new int[128];

        foreach (int[] bomb in bombs)
        {
            bool[,] hasDestroyed = new bool[whd[0], whd[2]];

            /*
            var stack = new Stack<Tuple<int, int, int>>();
            stack.Push(Tuple.Create(bomb[0], bomb[1], bomb[2]));
            var seenSet = new HashSet<Tuple<int, int, int>>();
            while (stack.Count > 0)
            {
                var triple = stack.Pop();

                if (!seenSet.Add(triple)) continue;

                int w = triple.Item1;
                int h = triple.Item2;
                int d = triple.Item3;

                if (w < 0 || h < 0 || d < 0)
                    continue;

                if (w >= whd[0] || h >= whd[1] || d >= whd[2])
                    continue;

                if (Distance(w, h, d, bomb) <= bomb[3])
                {
                    if (cuboid[w, h, d] != '\0')
                    {
                        destroyed[(int)cuboid[w, h, d]] += 1;
                        allDestroyed += 1;
                        cuboid[w, h, d] = '\0';
                        hasDestroyed[w, d] = true;
                    }
                    for (int dw = -1; dw <= 1; ++dw)
                    {
                        for (int dh = -1; dh <= 1; ++dh)
                        {
                            for (int dd = -1; dd <= 1; ++dd)
                            {
                                if (dw == 0 && dh == 0 && dd == 0) continue;
                                stack.Push(Tuple.Create(w + dw, h + dh, d + dd));
                            }
                        }
                    }
                }
            }
            /*/
            for (int w = 0; w < whd[0]; ++w)
            {
                for (int d = 0; d < whd[2]; ++d)
                {
                    for (int h = 0; h < whd[1]; ++h)
                    {
                        if (cuboid[w, h, d] == '\0')
                            break;
                        if (Distance(w, h, d, bomb) <= bomb[3])
                        {
                            hasDestroyed[w, d] = true;
                            destroyed[(int)cuboid[w, h, d]] += 1;
                            allDestroyed += 1;
                            cuboid[w, h, d] = '\0';
                        }
                    }
                }
            }
            //*/
            for (int w = 0; w < whd[0]; ++w)
            {
                for (int d = 0; d < whd[2]; ++d)
                {
                    // w h d
                    // 2 0 1
                    // 2 1 1
                    // 2 2 1
                    // 2 3 1

                    // A A A A B A A
                    // A                 V
                    // A * * * B A * * A A
                    // A B * * * A * * A A
                    // A B A * * * * * A A
                    // A B A A * * * * * A
                    // A B A A A * * * * *
                    // A B A A      

                    if (!hasDestroyed[w, d])
                        continue;
                    int holes = 0;

                    for (int h = 0; h < whd[1]; ++h)
                    {
                        if (cuboid[w, h, d] == '\0')
                        {
                            holes += 1;
                        }
                        else
                        {
                            if (holes != 0)
                            {
                                cuboid[w, h - holes, d] = cuboid[w, h, d];
                                cuboid[w, h, d] = '\0';
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(allDestroyed);
        for (char ch = 'A'; ch <= 'Z'; ++ch)
        {
            if (destroyed[(int)ch] != 0)
                Console.WriteLine("{0} {1}", ch, destroyed[(int)ch]);
        }
    }

    static double Distance(int x, int y, int z, int[] pt2)
    {
        // d = sqrt(dx^2+dy^2+dz^2)
        return Math.Sqrt(
            Math.Pow(x - pt2[0], 2) +
            Math.Pow(y - pt2[1], 2) +
            Math.Pow(z - pt2[2], 2)
            );
    }
}