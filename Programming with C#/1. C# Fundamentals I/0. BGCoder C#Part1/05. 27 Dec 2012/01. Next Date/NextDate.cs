using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        // solution
        DateTime date = new DateTime(year, month, day);
        date = date.AddDays(1);
        
        // print
        Console.WriteLine("{0}.{1}.{2}", date.Day, date.Month, date.Year);
    }
}