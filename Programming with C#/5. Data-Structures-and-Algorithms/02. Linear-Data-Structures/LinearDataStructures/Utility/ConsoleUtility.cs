namespace Utility
{
    using System;
    using System.Collections.Generic;

    public static class ConsoleUtility
    {
        public static IEnumerable<T> ReadSequenceOfElements<T>() where T : IComparable
        {
            var numbers = new List<T>();
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                var number = (T)Convert.ChangeType(input, typeof(T));
                numbers.Add(number);

                input = Console.ReadLine();
            }

            return numbers;
        }
    }
}
