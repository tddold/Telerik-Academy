// Problem 4. Unicode Character
// Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
// Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.

using System;

class UnicodeCharacter
{
    static void Main()
    {
        Console.Title = "Unicode Character";
        char number = '\u002a';
        int intValue = number;
        decimal decValue = number;

        Console.WriteLine("{0} ({1}) --> 0x{2:X4} ({3}) --> '\\u{4:X4}' ({5}) --> '{6}' ({7})", 
                            decValue, decValue.GetType().Name, intValue, intValue.GetType().Name, 
                            Convert.ToInt16(number), number.GetType().Name, number, number.GetType().Name);      
    }
}