using System;
//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.


class MaximalSumInArray
{
    static void Main()
    {
        //input
        Console.Write("Lenht of array:");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Maximal sum in K elements of array:");
        int k = int.Parse(Console.ReadLine());
        if (n < k)
        {
            Console.WriteLine("N must be bigger than K!");

            Console.Write("Lenht of array:");
            n = int.Parse(Console.ReadLine());

            Console.Write("Maximal sum in K elements of array:");
            k = int.Parse(Console.ReadLine());
        }
        int[] checkArray = new int[n]; //{ 64, 25, 12, 22, 11 };
        int result = 0;
        
        //input elements to Arrays
        for (int i = 0; i < n; i++)
        {
            checkArray[i] = int.Parse(Console.ReadLine());
        }

        //chec elements of Arrays
        Console.Write("Check array :");
        foreach (var item in checkArray)
        {
            Console.Write(item + ",");
        }

        Console.WriteLine();
        Console.WriteLine("Check array :" + string.Join(",", checkArray));

        //logic
        for (int i = 0; i < checkArray.Length - 1; i++) //this is sor logic
        {
            for (int j = i + 1; j < checkArray.Length; j++)
            {
                if (checkArray[i] > checkArray[j])
                {
                    int tmp = checkArray[j];
                    checkArray[j] = checkArray[i];
                    checkArray[i] = tmp;
                }
            }
        }

        for (int i = n - 1; i >= (n - k); i--) //this is aretmetic logic
        {
            result += checkArray[i];
        }

        //chec elements of Arrays after sort
        Console.WriteLine();
        Console.WriteLine("Check array :" + string.Join(",", checkArray));
        
        //output
        Console.WriteLine("Result is : {0}", result);





        //// testing
        //int[] checkArray = { 5, 2, 6, 4, 2, 6 };
        //// help values
        //string bestSeq = "";
        //int sum = 0;
        //int bestSum = int.MinValue;
        //int arrayLen = checkArray.Length;
        //for (int i = 0; i < arrayLen; i++)
        //{
        //    string currentSeq = "";
        //    // out of the array bounds
        //    if (i + 2 > arrayLen)
        //    {
        //        break;
        //    }
        //    // set check
        //    for (int j = i; j < i + 2; j++)
        //    {
        //        sum = sum + checkArray[j];
        //        currentSeq = currentSeq + ' ' + checkArray[j];
        //    }
        //    // best sum check
        //    if (sum > bestSum)
        //    {
        //        bestSeq = currentSeq;
        //        bestSum = sum;
        //    }
        //    sum = 0;
        //}
        //Console.WriteLine(bestSeq);
        //Console.WriteLine(bestSum);
    }
}
