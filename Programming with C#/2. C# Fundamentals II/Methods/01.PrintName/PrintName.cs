using System;

/*Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.
*/
public class PrintName
{
    public static string RegardstName(string userName)
    {
        //Console.WriteLine("Hello. {0}!", userName);
        return string.Format("Hello. {0}!", userName);
    }
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();

        Console.WriteLine(RegardstName(userName));
    }
}