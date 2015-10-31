namespace _02.ReverseSequence
{
    /*
    2. Write a program that reads N integers from the console and reverses them using a stack.
    Use the Stack<int> class.*/

    using System;
    using System.Collections.Generic;
    using Utility;

    public class ReverseSequenceUsingStack
    {
        public static void Main()
        {
            Console.WriteLine("Enter number for collection of numbers.");
            Console.WriteLine("Each one on a different rows.");
            Console.WriteLine("If row is empty end the collection.");

            var numbers = ConsoleUtility.ReadSequenceOfElements<int>();

            var numbersInStak = AddNumnersInStack(numbers);

            PrintelementsBackwards(numbersInStak);
        }

        private static void PrintelementsBackwards(Stack<int> numbersInStak)
        {
            while (numbersInStak.Count > 0)
            {
                Console.WriteLine(numbersInStak.Pop());
            }
        }

        private static Stack<int> AddNumnersInStack(IEnumerable<int> numbers)
        {
            var numbersInStack = new Stack<int>();

            foreach (var item in numbers)
            {
                numbersInStack.Push(item);
            }

            return numbersInStack;
        }
    }
}
