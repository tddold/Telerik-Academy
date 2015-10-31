namespace _05.RemoveNegativeNumbers
{
    /*
    5. Write a program that removes from given sequence all negative numbers
    .*/

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Utility;

    public class RemoveNegativeNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter number for collection of numbers.");
            Console.WriteLine("Each one on a different rows.");
            Console.WriteLine("If row is empty end the collection.");

            var collection = ConsoleUtility.ReadSequenceOfElements<int>().ToList();

            var positiveSequence = RemoveNegativeNumbersFromCollection(collection);

            Console.WriteLine("Positive collection is: {0}", string.Join(", ", positiveSequence));
        }

        private static IList<int> RemoveNegativeNumbersFromCollection(IList<int> collection)
        {
            collection = collection
                .Where(n => n >= 0)
                .ToList();

            return collection;
        }
    }
}
