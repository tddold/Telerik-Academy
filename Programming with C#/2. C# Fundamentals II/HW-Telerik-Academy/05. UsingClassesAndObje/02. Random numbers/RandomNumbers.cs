/*Problem 2. Random numbers
Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

namespace _02.Random_numbers
{
    using System;
    class RandomNumbers
    {
        static void Main()
        {
            Console.Title = "Problem 2. Random numbers";

            Console.WriteLine("Problem 2. Random numbers!");
            PrintSeparateLine();

            Random randomGenerator = new Random();

            Console.WriteLine("Prints random numbers in interval [100; 200]:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" {0,2} -> {1}", i+1, randomGenerator.Next(100, 201));
            }
            
            PrintSeparateLine();
        }

        static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
