namespace _03.SortInputElements
{
    /*
    3. Write a program that reads a sequence of integers (List<int>) ending with an empty line and 
    sorts them in an increasing order.*/

    using System;
    using System.Linq;
    using Utility;

    public class SortInputElements
    {
        public static void Main()
        {
            Console.WriteLine("Enter number for collection of numbers.");
            Console.WriteLine("Each one on a different rows.");
            Console.WriteLine("If row is empty end the collection.");

            var listOfNumbers = ConsoleUtility.ReadSequenceOfElements<int>();

            var sortedSequence = listOfNumbers
                .OrderBy(s => s)
                .ToList();

            Console.WriteLine("Sorted elements: {0}", string.Join(",", sortedSequence));
        }
    }
}
