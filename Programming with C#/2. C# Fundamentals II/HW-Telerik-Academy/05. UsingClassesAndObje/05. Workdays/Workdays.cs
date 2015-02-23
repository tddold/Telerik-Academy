/*Problem 5. Workdays
Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */

namespace _05.Workdays
{
    using System;
    using System.Linq;

    class Workdays
    {
        static readonly DateTime[] holydays =
        {
            new DateTime(2015, 1, 1), new DateTime(2015, 1, 2), new DateTime(2015, 3, 2),
            new DateTime(2015, 3, 3), new DateTime(2015, 4, 10), new DateTime(2015, 4, 13),
            new DateTime(2015, 5, 1), new DateTime(2015, 5, 6), new DateTime(2015, 9, 21),
            new DateTime(2015, 9, 22), new DateTime(2015, 12, 24), new DateTime(2015, 12, 25),
            new DateTime(2015, 12, 31)
        };

        static void Main()
        {
            Console.Title = "Problem 5. Workdays";

            Console.WriteLine("Problem 5. Workdays!");
            PrintSeparateLine();

            Console.Write("Enter the month which workdays you want : ");
            int holMonth = int.Parse(Console.ReadLine());
            Console.Write("Enter the day of the month : ");
            int holDay = int.Parse(Console.ReadLine());

            DateTime dateNow = DateTime.Now;
            DateTime dateCheck = new DateTime(2015, holMonth, holDay);

            if (dateNow > dateCheck)
            {
                Console.WriteLine("\nInvalid date. \nMonth mast be after {0}, and day mast be after {1}.", dateNow.Month, dateNow.Day);
                PrintSeparateLine();
                return;
            }

            Console.WriteLine("\nChecking work days from {0:dd/MM/yyyy} to {1:dd/MM/yyyy}...\n", 
            dateNow, dateCheck);

            Console.WriteLine("Total work days is: {0}" , GetWorkDays(dateNow, dateCheck));
           
            PrintSeparateLine();
        }

        static int GetWorkDays(DateTime dateNow, DateTime dateCheck)
        {
            int workDays = 0;

            while (dateNow <= dateCheck)
            {
                if (!(holydays.Contains(dateNow)) && dateNow.DayOfWeek != DayOfWeek.Saturday && dateNow.DayOfWeek != DayOfWeek.Sunday)
                {
                    workDays++;
                }

                dateNow = dateNow.AddDays(1);
            }
           
            return workDays;
        }

        static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
