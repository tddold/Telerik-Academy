// Problem 15.* Age after 10 Years
// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Title = "Age after 10 Years";
        Console.Write("Enter the year when you were born :");
        int bornYear = int.Parse(Console.ReadLine());
        int curentYear = DateTime.Now.Year;
        int ageNow;
        int ageAfter;
        if (bornYear >= 1900 && bornYear < curentYear)
        {
            ageNow = curentYear - bornYear;
            ageAfter = ageNow + 10;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("Your age now is {0}, but your age in 10 years will be {1}", ageNow, ageAfter);
            Console.WriteLine(new string('-', 60));
        }
    }
}