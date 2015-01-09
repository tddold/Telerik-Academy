using System;

//Write a program that compares two char arrays lexicographically (letter by letter)

class CompareTwoCharArrays
{
    static void Main()
    {
        //input
        Console.Write("Lenht first array:");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Lenht second array:");
        int n2 = int.Parse(Console.ReadLine());

        int compareLenght;
        int earleyArray=0;
        char[] firstArray = new char[n1]; //{ 'a', 's', 'd', 'f', 'g', 'h' };
        char[] secondArray = new char[n2]; //{ 'a', 's', 'd', 'f' };

        //input elements to Arrays
        for (int i = 0; i < n1; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n2; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        //chec elements of Arrays
        Console.Write("First array :");
        foreach (var item in firstArray)
        {
            Console.Write(item + ",");
        }

        Console.WriteLine();
        Console.WriteLine("Second array:" + string.Join(",", secondArray));

        //logic
        if (n1 < n2)
        {
            compareLenght = n1;
        }
        else
        {
            compareLenght = n2;
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

        if (earleyArray == 1)
        {
            Console.WriteLine("The second array is earlier.");
        }
        else if (earleyArray == 2)
        {
            Console.WriteLine("The first array is earlier.");
        }
        else
        {
            Console.WriteLine("The two arrays are the same.");
        }
    }
}