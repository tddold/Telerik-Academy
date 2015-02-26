/*Problem 19. Dates from text in Canada
Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

class DatesFromTextCanada
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");

        Console.WriteLine("Problem 19. Dates from text in Canada");
        Console.WriteLine(new string('-', 40));

        string text = "Simple text: I was born at 14.06.1988. My sister was born at 3.7.1994. In 5/2008 I graduated my high school. Section for test (see section 7.3.12) sectoin for test (section 7.4.2.9).";

        string[] words = text.Split(new string[] { " ", ";", ",", ". " }, StringSplitOptions.RemoveEmptyEntries);

        string format = "d.M.yyyy";
        CultureInfo newDateFormat = Thread.CurrentThread.CurrentCulture;

        string regex = @"[\d]{1,2}.[\d]{1,2}.[\d]{4}";

        Console.WriteLine("Extracted dates from the sample text:\n");

        for (int i = 0; i < words.Length; i++)
        {
            if (Regex.IsMatch(words[i], regex))
            {
                try
                {
                    DateTime isCheck = DateTime.ParseExact(words[i].ToString(), format, newDateFormat);
                    Console.WriteLine(" #{0}", isCheck.ToShortDateString());
                }
                catch (FormatException)
                {

                    continue;
                }
            }
        }

        Console.WriteLine(new string('-', 40));
    }
}