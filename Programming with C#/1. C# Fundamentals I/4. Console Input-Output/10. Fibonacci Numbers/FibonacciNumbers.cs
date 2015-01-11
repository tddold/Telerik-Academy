/*Problem 10. Fibonacci Numbers
Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.*/

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Title = "Fibonacci Numbers";

        Console.WriteLine("Fibonacci Numbers!");
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter number of Fibonacci sequence: ");
        int n;
        while ((!int.TryParse(Console.ReadLine(), out n)) || n < 1)
        {
            Console.Write("Invalid parameter! Enter number: ");
        }

        int counter = 0;
        int sequencenumber1 = 0;
        int sequenceNumber2 = 1;

        //WHILE method
        Console.WriteLine(new string('-', 40));
        Console.Write("Result by While loop --> ");        
        if (n == 1)
        {
            Console.WriteLine(sequencenumber1);
        }
        else if (n == 2)
        {
            Console.Write("{0} {1} ", sequencenumber1, sequenceNumber2);
        }
        else
        {
            Console.Write("{0} {1} ", sequencenumber1, sequenceNumber2);
            while (counter != n - 2)
            {
                int sequenceNew = sequencenumber1 + sequenceNumber2;
                sequencenumber1 = sequenceNumber2;
                sequenceNumber2 = sequenceNew;
                Console.Write("{0} ", sequenceNew);
                counter++;
            }
        }

        Console.WriteLine();
        
        // IF method
        sequencenumber1 = 0;
        sequenceNumber2 = 1;

        Console.Write("Result by For loop   --> ");
        if (n == 1)
        {
            Console.WriteLine(sequencenumber1);
        }
        else
        {
            Console.Write("{0} {1} ", sequencenumber1, sequenceNumber2);
            for (int i = 3; i <= n; i++)
            {
                int sequenceNew = sequencenumber1 + sequenceNumber2;
                sequencenumber1 = sequenceNumber2;
                sequenceNumber2 = sequenceNew;
                Console.Write("{0} ", sequenceNew);
            }
        }
               
        Console.WriteLine("\n{0}", (new string('-', 40)));
    }
}