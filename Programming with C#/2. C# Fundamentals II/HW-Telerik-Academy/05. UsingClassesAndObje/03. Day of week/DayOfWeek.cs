/*Problem 3. Day of week
Write a program that prints to the console which day of the week is today.
Use System.DateTime.
 */

namespace _03.Day_of_week
{
    using System;
    class DayOfWeek
    {
        static void Main()
        {
            Console.Title = "Problem 3. Day of week";

            Console.WriteLine("Problem 3. Day of week!");
            PrintSeparateLine();

            DateTime today = DateTime.Now;

            Console.WriteLine("Today is : {0}", today.DayOfWeek);
            PrintSeparateLine();
        }

        static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
