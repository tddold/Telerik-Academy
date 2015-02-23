/*Problem 1. Leap year
Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
 */

namespace _01.Leap_year
{
    using System;
    using System.Globalization;

    class LeapYear
    {
        static void Main()
        {
            Console.Title = "Problem 1. Leap year";

            Console.WriteLine("Problem 1. Leap year!");
            PrintSeparateLine();

            Console.Write("Enter year: ");
            //int year = int.Parse(Console.ReadLine());
            //DateTime leapYear = new DateTime(year, 1, 1);
            
           DateTime leapYear = DateTime.Parse("1.1." + Console.ReadLine() + "");

            Console.WriteLine("Year {0} is leap: {1}", leapYear.Year, DateTime.IsLeapYear(leapYear.Year));
            PrintSeparateLine();
        }

        static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}


    

