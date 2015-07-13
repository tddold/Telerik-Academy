namespace LoopRefactoring
{
    using System;

    public class Refactor
    {
        public static void Main()
        {
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            int expectedValue = 50;
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        i = 666;
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }

                // More code here
                if (i == 666)
                {
                    Console.WriteLine("Value Found");
                    break;
                }
            }
        }
    }
}
