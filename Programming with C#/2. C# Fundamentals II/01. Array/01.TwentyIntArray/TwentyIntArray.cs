using System;
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

    class TwentyIntArray
    {
        static void Main()
        {
            //input
            int[] intArray = new int[20];

            //logic
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 5;
            }

            //output
            foreach (var item in intArray)
            {
                Console.Write(item + " ");               
            }
            Console.WriteLine();
        }
    }