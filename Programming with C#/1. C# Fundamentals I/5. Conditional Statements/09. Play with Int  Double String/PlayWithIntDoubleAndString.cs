/*Problem 9. Play with Int, Double and String
Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Title = "Play with Int, Double and String";

        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int" + "\n2 --> double" + "\n3 --> string");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.Write("Please enter a int:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Result --> " + (num + 1));
                break;
            case 2:
                Console.Write("Please enter a double:");
                double numDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Result --> " + (numDouble + 1));
                break;
            case 3:
                Console.Write("Please enter a string:");
                string strInput = Console.ReadLine();
                Console.WriteLine("Result --> " + strInput + "*");
                break;
            default:
                Console.WriteLine("Ivalid parameter");
                break;
        }
    }
}