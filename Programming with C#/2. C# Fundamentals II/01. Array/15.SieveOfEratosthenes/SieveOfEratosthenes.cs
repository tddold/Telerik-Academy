using System;
//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).


class SieveOfEratosthenes
{
    static void Main()
    {
        //input
        Console.Write("Input number of lenght in the rane N = ");
        int number = int.Parse(Console.ReadLine());

        //def the array
        bool[] array = new bool[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = true;
        }

        //check the array
        //Console.WriteLine(string.Join(",", array));

        //logic
        int max = (int)Math.Sqrt(array.Length);
        Console.WriteLine("max = {0}", max);

        for (int i = 2; i < max; i++)
        {
            if (array[i])
            {
                for (int j = i*i; j < array.Length; j+=i)
                {
                    array[j] = false;
                }
            }
        }
        
        //output
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i])
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}