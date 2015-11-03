namespace _12.Stack_ADT
{
    using System;

    /// <summary>
    /// 12. Implement the ADT stack as auto-resizable array.
    /// Resize the capacity on demand(when no space is available to add / insert a new element).
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            PrintResult(stack);

            Console.WriteLine("Stack count: {0}", stack.Count);
            Console.WriteLine("Stack capacity: {0}", stack.Capacity);
        }

        private static void PrintResult(Stack<int> stack)
        {
            Console.Write("Item value: ");

            foreach (var item in stack)
            {
                Console.Write("{0}, ", item);
            }

            Console.WriteLine();
        }
    }
}
