/*Problem 8. Isosceles Triangle
Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©
Note: The © symbol may be displayed incorrectly at the console so you may need to change the console 
 * character encoding to UTF-8 and assign a Unicode-friendly font in the console.

Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of 
 * how much effort you put to fix it.*/

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.Title = "Isosceles Triangle";

        char copyRidht = '\u00A9';

        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("{0,4}", copyRidht);
        Console.WriteLine("{0,3}{1,2}", copyRidht, copyRidht);
        Console.WriteLine("{0,2}{1,2}{2,2}", copyRidht, " ", copyRidht);
        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", copyRidht, " ", copyRidht, " ", copyRidht, " ", copyRidht);
        Console.WriteLine(new string('-', 40));

        // Another way to display triangle
        int thighLength = 4;
        for (int i = 1; i <= thighLength; i++)
        {
            Console.Write(new string(' ', thighLength - i)); // add white spaces

            for (int j = 1; j <= i; j++)
            {
                if (i == 3 && j == 2)
                {
                     Console.Write("{0} ", " ");
                }
                else
                {
                    Console.Write("{0} ", copyRidht);
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}