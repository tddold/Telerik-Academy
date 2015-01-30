/*Problem 3. Compare char arrays
Write a program that compares two char arrays lexicographically (letter by letter).*/
using System;
using System.Globalization;
using System.Threading;

class CompareCharArrays
{
    static void Main()
    {
        Console.Title = "Problem 2. Compare arrays!";

        // setting  for culture
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;        

        // input
        Console.WriteLine("Compare arrays!");
        Console.WriteLine(new string('-', 40));

        Console.Write("Enter alfabet to first char array (abcd) : ");
        string firstText = Console.ReadLine();                                      // "abcdefgh";

        Console.Write("Enter alfabet to second char array (abcd): ");
        string secondText = Console.ReadLine();                                     // "absdef";        

        int earleyArray = new int();
        int compareLenght;

        // **********************************input elements for Arrays ****************************
        // add elements to first array
        Console.WriteLine(new string('-', 40));
        
        char[] firstArray = firstText.ToCharArray();                // convert string to char array

        // add elements to second array
        char[] secondArray = secondText.ToCharArray();              // convert string to char array

        // ****************print first and second array********************************************
        // print first array using foreach
        Console.Write("First array : ");
        foreach (var item in firstArray)
        {
            Console.Write("{0}, ", item);
        }

        Console.WriteLine();

        //print second array using string.join
        Console.WriteLine("Second array: " + string.Join(", ", secondArray));

        // logic        
        if (firstArray.Length < secondArray.Length)
        {
            compareLenght = firstArray.Length;
        }
        else
        {
            compareLenght = secondArray.Length;
        }

        for (int i = 0; i < compareLenght; i++)
        {
            if (firstArray[i] < secondArray[i])
            {
                earleyArray = 1;
                break;
            }
            else if (firstArray[i] > secondArray[i])
            {
                 earleyArray = 2;
                break;
            }
        }

        Console.WriteLine(new string('-', 40));
        if (earleyArray == 1)
        {
            Console.WriteLine("Arrays aren't equal. The first array is earlier.");
        }
        else if (earleyArray == 2)
        {
            Console.WriteLine("Arrays aren't equal. The second array is earlier.");
        }
        else
        {
            Console.WriteLine("Both arrays are equal");
        }
        
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();
    }
}