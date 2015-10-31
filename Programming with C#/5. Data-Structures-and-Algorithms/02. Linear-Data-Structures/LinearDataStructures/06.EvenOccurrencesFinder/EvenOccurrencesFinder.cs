namespace _06.EvenOccurrencesFinder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EvenOccurrencesFinder
    {
        public static void Main()
        {
            var numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            var isOddNumberOfTime = false;
            var extractedElements = FindElementsUsingHashSet(numbers, isOddNumberOfTime);
            PrintResult(numbers, extractedElements);

            var extractElementsTwo = FindElementsUsingDictionary(numbers);
            Console.WriteLine("Result two: {0}", string.Join(", ", extractElementsTwo));
        }

        public static List<int> FindElementsUsingDictionary(List<int> numbers)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!dict.ContainsKey(numbers[i]))
                {
                    dict.Add(numbers[i], 1);
                }
                else
                {
                    dict[numbers[i]]++;
                }
            }

            numbers = numbers
                .Where(e => dict[e] % 2 == 0)
                .ToList();

            return numbers;
        }

        public static ISet<T> FindElementsUsingHashSet<T>(IList<T> numbers, bool isOddNumberOfTime)
        {
            var oddOccurrences = new HashSet<T>();
            var evenOccurrences = new HashSet<T>();

            foreach (var item in numbers)
            {
                if (oddOccurrences.Add(item))
                {
                    evenOccurrences.Remove(item);
                }
                else
                {
                    oddOccurrences.Remove(item);
                    evenOccurrences.Add(item);
                }
            }

            return isOddNumberOfTime ? oddOccurrences : evenOccurrences;
        }

        private static void PrintResult(List<int> numbers, ISet<int> extractedElements)
        {
            var resultElements = numbers
                .Where(e => extractedElements.Contains(e));

            Console.WriteLine("Result is: {0}", string.Join(", ", resultElements));
        }
    }
}
