using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new[] { 3, 34, 4, 12, 5, 2 };
            var sum = 45;

            Console.WriteLine("Numbers: {0}", string.Join(", ", set));
            Console.WriteLine("Search dor: {0}", sum);

            if (IsSubsetSum(set, sum))
            {
                Console.WriteLine("Found a sub set sum with given sum");
            }
            else
            {

            }
        }

        static bool IsSubsetSum(int[] set, int sum)
        {
            const int NotSet = -1;
            var sumOfAll = set.Sum();
            var last = new int[sumOfAll + 1];
            var currentSum = 0;

            for (var i = 1; i < sumOfAll; i++)
            {
                last[i] = NotSet;
            }

            for (var i = 0; i < set.Length; i++)
            {
                for (var j = currentSum; j + 1 > 0; j--)
                {
                    if (last[j] != NotSet &&
                        last[j + set[i]] == NotSet)
                    {
                        last[j + set[i]] = i;
                    }
                }
                currentSum += set[i];
            }
            return last[sum] != NotSet;
        }
    }
}
