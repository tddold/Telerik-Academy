namespace ColoredRabbits
{
    using System;
    using System.Collections.Generic;

    public class Solve
    {
        public static void Main()
        {
            var rabbitCount = new Dictionary<int, int>();

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int rabbit = int.Parse(Console.ReadLine()) + 1;

                if (!rabbitCount.ContainsKey(rabbit))
                {
                    rabbitCount.Add(rabbit, 0);
                }

                rabbitCount[rabbit]++;
            }

            int totalRabbits = 0;

            foreach (var rabbits in rabbitCount)
            {
                totalRabbits += (int)Math.Ceiling((double)rabbits.Value / rabbits.Key) * rabbits.Key;
            }

            Console.WriteLine(totalRabbits);

        }
    }
}
