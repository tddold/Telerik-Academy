/*Problem 3. Range Exceptions
 * Define a class InvalidRangeException<T> that holds information about an error condition related to 
 * invalid range. It should hold error message and a range definition [start … end].
 * Write a sample application that demonstrates the InvalidRangeException<int> and 
 * InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range 
 * [1.1.1980 … 31.12.2013].*/

namespace Range_Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RangeExceptionsMain
    {
        public static void Main()
        {
            Console.WriteLine("Problem 3. Range Exceptions");
            PrintSeparateLine();

            string startDate = "1.1.1980";
            string endDate = "31.12.2015";

            InvalidRangeException<DateTime> someYear = new InvalidRangeException<DateTime>("Dates must be in range [1.1.1980 … 31.12.2015]", DateTime.Parse(startDate), DateTime.Parse(endDate));

            Console.Write("Enter 3 dates:\n");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Date {0}: ", i + 1);
                DateTime dateElement = DateTime.Parse(Console.ReadLine());

                if (dateElement.Year < someYear.Start.Year || dateElement.Year > someYear.End.Year)
                {
                    throw someYear;
                }
                else if (dateElement.Month < someYear.Start.Month || dateElement.Month > someYear.End.Month)
                {
                    throw someYear;
                }
                else if (dateElement.Day < someYear.Start.Day || dateElement.Day > someYear.End.Day)
                {
                    throw someYear;
                }
            }

            InvalidRangeException<int> someInt = new InvalidRangeException<int>("Nums must be in range [1..100]", 1, 100);

            Console.Write("\nEnter 3 nums:\n");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                int intElement = int.Parse(Console.ReadLine());

                if (intElement < someInt.Start || intElement > someInt.End)
                {
                    throw someInt;
                }
            }

            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
