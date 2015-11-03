namespace _13.Queue_ADT
{
    using System;

    /// <summary>
    /// 13. Implement the ADT queue as dynamic linked list.
    /// Use generics(LinkedQueue<T>) to allow storing different data types in the queue.
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            PrintResult(queue);

            Console.WriteLine("Queue count: {0}", queue.Count);
            Console.WriteLine("Queue peek: {0}", queue.Peek());
        }

        private static void PrintResult(Queue<int> queue)
        {
            Console.Write("Item value: ");

            foreach (var item in queue)
            {
                Console.Write("{0}, ", item);
            }

            Console.WriteLine();
        }
    }
}
