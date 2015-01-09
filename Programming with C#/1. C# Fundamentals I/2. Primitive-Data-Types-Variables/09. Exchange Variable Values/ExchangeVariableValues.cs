/*Problem 9. Exchange Variable Values
Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their
 * values by using some programming logic.
Print the variable values before and after the exchange.*/

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        Console.Title = "Exchange Variable Values";

        int a = 5;
        int b = 10;
        int tmp;

        Console.WriteLine("Print variable befor exchenge:");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine();

        tmp = a;
        a = b;
        b = tmp;

        Console.WriteLine("Print variable after exchenge:");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
    }
}