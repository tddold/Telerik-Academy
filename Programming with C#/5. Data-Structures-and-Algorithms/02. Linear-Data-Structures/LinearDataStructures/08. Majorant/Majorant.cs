namespace _08.Majorant
{
    /*
    *The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
    Write a program to find the majorant of given array (if exists).
    Example:{2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
        */

    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Majorant
    {
        public static void Main()
        {
            var numbers = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            var countNumbers = FindMajorant(numbers);

            PrintResult(countNumbers);
        }

        public static void PrintResult(int? majorant)
        {
            Console.WriteLine(majorant.HasValue ? "Majorant: " + majorant.ToString() : "There is no majorant.");
        }

        private static Nullable<T> FindMajorant<T>(IList<T> numbers) where T : struct
        {
            int majorantMedian = numbers.Count / 2 + 1;
            T? majorant = null;

            var dictionary = new Dictionary<T, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!dictionary.ContainsKey(numbers[i]))
                {
                    dictionary.Add(numbers[i], 1);

                }
                else
                {
                    dictionary[numbers[i]]++;
                }
            }

            majorant = dictionary.FirstOrDefault(n => n.Value >= majorantMedian).Key;

            return majorant;
        }
    }
}
