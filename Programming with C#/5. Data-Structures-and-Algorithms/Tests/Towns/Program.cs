namespace Towns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var number = int.Parse(line[0]);
                numbers.Add(number);
            }

            var answer = Slove(numbers);
            Console.WriteLine(answer);
        }

        private static int Slove(List<int> numbers)
        {
            int[] leftToRight = new int[numbers.Count];

            for (int i = 0; i < numbers.Count; i++)
            {
                int maxLength = 0;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        maxLength = Math.Max(maxLength, leftToRight[j]);
                    }
                }

                leftToRight[i] = maxLength + 1;
            }

            int[] rightToLeft = new int[numbers.Count];
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                int maxLength = 0;
                for (int j = numbers.Count - 1; j > i; j--)
                {
                    if (numbers[j] < numbers[i])
                    {
                        maxLength = Math.Max(maxLength, rightToLeft[j]);
                    }
                }

                rightToLeft[i] = maxLength + 1;
            }

            // 3. combine and find max answer
            var maxPath = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                var path = leftToRight[i] + rightToLeft[i] - 1;
                maxPath = Math.Max(maxPath, path);
            }

            return maxPath;
        }
    }
}
