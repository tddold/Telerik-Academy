using System;

class CompareToArray
{
    static void Main()
    {
        //input
        Console.Write("Lenht first array:");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Lenht second array:");
        int n2 = int.Parse(Console.ReadLine());

        int compareLenght;
        bool isSimetric = true;
        int[] firstArray = new int[n1];
        int[] secondArray = new int[n2];

        //input elements to Arrays
        for (int i = 0; i < n1; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n2; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
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
            if (firstArray[i] != secondArray[i])
            {
                isSimetric = false;
                break;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The arrays is simetric:{0}", isSimetric);
    }
}