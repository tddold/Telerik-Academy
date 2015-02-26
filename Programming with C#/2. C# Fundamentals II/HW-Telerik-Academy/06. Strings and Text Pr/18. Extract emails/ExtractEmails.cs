/*Problem 18. Extract e-mails
Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        Console.WriteLine("Problem 18. Extract e-mails");
        Console.WriteLine(new string('-', 40));

        string text = @"Sample text for testing: Please contact us by phone (+1-800-555-2468)or by valid e-mail foo@demo.net bar.ba@test.co.uk or by invalid email  foo@demo.net.. www.demo.com http://foo.co.uk/http://regexr.com/foo.html?q=bar";

        string[] words = text.Split(new string[] {  " ", ";", ",", ". "}, StringSplitOptions.RemoveEmptyEntries);
        string regex = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" +
                       @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})$";

        Console.WriteLine("Extracted e-mail addresses:\n");
       
        for (int i = 0; i < words.Length; i++)
        {
            if (Regex.IsMatch(words[i], regex))
            {
                Console.WriteLine(" - {0}", words[i]);
            }
        }

        Console.WriteLine(new string('-', 40));
    }
}