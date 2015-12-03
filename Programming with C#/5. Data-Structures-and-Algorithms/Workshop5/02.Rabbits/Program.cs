namespace _02.Rabbits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var inputAnswers = line.Split(' ').Select(int.Parse).ToList();
            inputAnswers.RemoveAt(inputAnswers.Count - 1);

            var answer = MinRabbitsCount(inputAnswers);
            Console.WriteLine(answer);
        }

        public static int MinRabbitsCount(IEnumerable<int> answers)
        {
            var groups = new Dictionary<int, int>();

            foreach (var answer in answers)
            {
                if (!groups.ContainsKey(answer + 1))
                {
                    groups.Add(answer + 1, 0);
                }

                groups[answer + 1]++;
            }

            var rabbits = 0;

            foreach (var group in groups)
            {
                var size = group.Key;
                var rabbitsInGroup = group.Value;

                var groupsCount = (int)Math.Ceiling(rabbitsInGroup / (decimal)size);

                rabbits += groupsCount * size;
            }

            return rabbits;
        }
    }
}
