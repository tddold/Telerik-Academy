/*Problem 7. Encode/decode
Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class EncodeDecode
{
    public static string EncodingText(string input, string key)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            sb.Append((char) (input[i] ^ key[i % key.Length]));
        }

        return sb.ToString();
    }

    public static string DecodingText(string input, string key)
    {
        return EncodingText(input, key);
    }

    static void PrintSeparateLine()
    {
        Console.WriteLine(new string('-', 40));
    }

    public static void Main()
    {
        Console.WriteLine("Problem 7. Encode/decode");
        PrintSeparateLine();

        Console.Write("\nEnter string: ");
        string input = Console.ReadLine();

        Console.Write("Enter key(a sequence of characters): ");
        string key = Console.ReadLine();

        Console.WriteLine("\nCodeword     - {0}", EncodingText(input, key));

        Console.WriteLine("\nDecoded word - {0}", DecodingText(EncodingText(input, key), key));
        PrintSeparateLine();
    }




}