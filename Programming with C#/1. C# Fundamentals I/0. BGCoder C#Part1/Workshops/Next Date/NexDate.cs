using System;

class NexDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int mounth = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        DateTime currentDate = new DateTime(year, mounth, day);

        currentDate = currentDate.AddDays(1);

        Console.WriteLine(currentDate.Day + "." + currentDate.Month + "." + currentDate.Year);
    }
}