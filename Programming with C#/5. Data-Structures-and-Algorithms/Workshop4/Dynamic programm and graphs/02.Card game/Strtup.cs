namespace Card_game
{
    using System;
    using System.Linq;
    public class Strtup
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[,] subs = new int[N, N];

            for (int i = 3; i <= N; i++)
            {
                for (int j = 0; j <= N - i; j++)
                {
                    for (int k = j + 1; k < i + j - 1; k++)
                    {
                        int current = subs[j, k] + subs[k, j + i - 1] + numbers[k] * (numbers[j] + numbers[j + i - 1]);
                        if (subs[j, j + i - 1] < current)
                        {
                            subs[j, j + i - 1] = current;
                        }
                    }
                }
            }

            Console.WriteLine(subs[0, N - 1]);
        }
    }
}
