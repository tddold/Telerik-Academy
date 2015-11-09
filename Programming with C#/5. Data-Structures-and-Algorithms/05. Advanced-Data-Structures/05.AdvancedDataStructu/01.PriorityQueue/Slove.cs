namespace _01.PriorityQueue
{
    /*
    1.Implement a class PriorityQueue<T> based on the data structure "binary heap".
        */

    using System;
    using System.Collections.Generic;

    public class Slove
    {
        private static void Main()
        {
            var priorityQueueInts = new PriorityQueue<int>();

            priorityQueueInts.Add(5);
            priorityQueueInts.Add(10);
            priorityQueueInts.Add(-5);
            priorityQueueInts.Add(1);
            priorityQueueInts.Add(13);
            priorityQueueInts.Add(13);
            priorityQueueInts.Add(0);
            priorityQueueInts.Add(25);

            Console.WriteLine(string.Join(", ", priorityQueueInts));

            var numbersActualOrder = new List<int>();

            while (priorityQueueInts.Count > 0)
            {
                numbersActualOrder.Add(priorityQueueInts.RemoveFirst());
            }

            Console.WriteLine("Removed of this steps: {0}", string.Join(", ", numbersActualOrder));

            var priorityQueueHumans = new PriorityQueue<Human>();

            priorityQueueHumans.Add(new Human("Ivan", 25));
            priorityQueueHumans.Add(new Human("Georgi", 13));
            priorityQueueHumans.Add(new Human("Cvetelina", 18));
            priorityQueueHumans.Add(new Human("Plamena", 22));
            priorityQueueHumans.Add(new Human("Gergana", 23));
            priorityQueueHumans.Add(new Human("Qna", 21));

            Console.WriteLine(string.Join(", ", priorityQueueInts));

            var numbersActualOrderHuman = new List<string>();

            while (priorityQueueHumans.Count > 0)
            {
                var removedHuman = priorityQueueHumans.RemoveFirst().Name;
                numbersActualOrderHuman.Add(removedHuman);
            }

            Console.WriteLine("Removed of this steps: {0}", string.Join(", ", numbersActualOrderHuman));
        }
    }
}
