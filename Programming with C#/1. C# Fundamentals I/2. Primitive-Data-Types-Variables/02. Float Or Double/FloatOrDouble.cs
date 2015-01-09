// Problem 2. Float or Double?
//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        Console.Title = "Float or Double";

        float floatVar1 = 12.345f;
        float floatVar2 = 3456.091f;
        double doubleVar1 = 8923.1234857;
        double doubleVar2 = 34.567839023;

        Console.WriteLine("Number of float type is:");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(floatVar1 + " -> " + floatVar1.GetTypeCode());
        Console.WriteLine(floatVar2 + " -> " + floatVar2.GetTypeCode());

        Console.WriteLine();
        Console.WriteLine("Number of double type is:");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(doubleVar1 + " -> " + doubleVar1.GetTypeCode());
        Console.WriteLine(doubleVar2 + " -> " + doubleVar2.GetTypeCode());
    }
}