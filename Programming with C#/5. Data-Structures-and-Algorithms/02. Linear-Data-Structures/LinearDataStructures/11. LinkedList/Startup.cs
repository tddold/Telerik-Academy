namespace _11.LinkedList
{
    using System;

    /// <summary>
    /// 11. Implement the data structure linked list.
    /// Define a class ListItem<T> that has two fields: value(of type T) and NextItem(of type <T>).
    /// Define additionally a class LinkedList<T> with a single field FirstElement(of type ListItem<T>).
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var testList = new LinkedList<int>();

            testList.AddFirst(6);
            testList.AddFirst(1);
            testList.AddLast(0);
            testList.AddLast(9);

            PrintResult(testList);

            testList.RemoveFirst();
            testList.RemoveLast();
            testList.Remove(0);

            PrintResult(testList);
        }

        private static void PrintResult(LinkedList<int> testList)
        {
            Console.Write("Item value: ");

            foreach (var item in testList)
            {
                Console.Write("{0}, ", item);
            }

            Console.WriteLine();
        }
    }
}
