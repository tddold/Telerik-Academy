/*Problem 17. Date in Bulgarian
Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

class DateInBulgarian
{
    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void Main()
    {
        Console.WriteLine("Problem 17. Date in Bulgarian");
        PrintSeparateLine();

        // string str = "03.3.2015 12:30:00";

        Console.Write("Enter date (d.M.yyyy H:mm:ss): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy H:mm:ss", CultureInfo.InvariantCulture);

        date = date.AddHours(6);
        date = date.AddMinutes(30);

        Console.WriteLine("\nDate after 6 hours and 30 mins: {0}", date.ToString("dddd dd.MM.yyyy HH:mm:ss", new CultureInfo("bg-BG")));
        PrintSeparateLine();
    }
}