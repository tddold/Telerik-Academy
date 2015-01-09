/*Problem 5. Boolean Variable
Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
Print it on the console.*/

using System;

class BooleanVariable
{
    static void Main()
    {
        Console.Title = "Boolean Variable";

        bool isFemale = false;
        Console.WriteLine("Write number:\nIf you is Male - \"1\"\nIf you is Female - \"2\"");
        int sex = int.Parse(Console.ReadLine());
        if (sex == 2)
        {
            isFemale = true;
        }
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("You are is Female is:" + isFemale);
        Console.WriteLine(new string('-', 40));
    }
}