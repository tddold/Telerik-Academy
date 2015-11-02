namespace _07.Number_Of_Occurences
{
    /*
    7. Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
    Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    2 → 2 times
    3 → 4 times
    4 → 3 times
        */

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumberOfOccurences
    {
        public static void Main()
        {
            var numbers = new List<int> { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var countNumbers = FindeTimesOfOccursNumbers(numbers);

            PrintResult(countNumbers);
        }

        private static void PrintResult(Dictionary<int, int> dictionary)
        {
            foreach (var item in dictionary.OrderBy(k => k.Key))
            {
                Console.WriteLine("Number {0} -> {1} times", item.Key, item.Value);
            }
        }

        private static Dictionary<int, int> FindeTimesOfOccursNumbers(IList<int> numbers)
        {
            var dictionary = new Dictionary<int, int>();

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

            return dictionary;
        }
    }
}
