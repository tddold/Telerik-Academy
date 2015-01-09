/*Problem 14.* Print the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
Note: You may need to use for-loops (learn in Internet how).*/

using System;
using System.Text;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.Title = "";

        Console.WriteLine("Print ASCII Table");



        string ASCII = @"ASCII includes definitions for 128 characters: 33 are non-printing control characters that affect how text and space are processed and 95 printable characters, including the space.";
        Console.WriteLine(ASCII);
        Console.WriteLine("\nList of all visible ASCII symbols: ");

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine();

        for (int i = 33; i <= 126; i++)
        {
            if ((i + 3) % 6 == 0)
            {
                Console.WriteLine();
            }
            Console.Write("{1:000}: {0, -4}", (char) i, i);
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 80));
        Console.WriteLine("\nList of all visible ASCII symbols: ");

        StringBuilder tableASCII = new StringBuilder();

        for (byte symbol = 33; symbol <= 254; symbol++)
        {
            if ((symbol + 3) % 6 == 0)
            {
                tableASCII.AppendLine();
            }

            tableASCII.AppendFormat("{0:000}: {1,-8}", symbol, (char) symbol);
        }

        Console.WriteLine(tableASCII + Environment.NewLine);
    }
}