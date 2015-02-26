/*Problem 16. Date difference
Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:
Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

class DateDifference
{
    public static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    static void Main()
    {
        Console.WriteLine("Problem 16. Date difference");
        PrintSeparateLine();

        Console.Write("Enter the first date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter the second date: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("\nDistance between {0} and {1} -> {2}days", firstDate, secondDate, Math.Abs((secondDate - firstDate).TotalDays));
        PrintSeparateLine();
    }
}