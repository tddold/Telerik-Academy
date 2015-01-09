using System;
//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


class MaxIncreasingSiquence
{
    static void Main()
    {
        //input
        int[] checkArray = { 3, 2, 3, 4, 2, 2, 4 };

        string result = "";
        int subResult = 0;

        //check array
        Console.WriteLine(string.Join(",", checkArray));

        //logic
        for (int i = 0; i < checkArray.Length; i++)
        {
            if (i != 0 && i < (checkArray.Length - 1))
            {
                if (checkArray[i] == (checkArray[i + 1] - 1))
                {
                    result = result + checkArray[i].ToString();
                    subResult = checkArray[i + 1];
                }
            }
        }

        //output
        result = result + subResult.ToString();
        Console.WriteLine(string.Join(",", result.ToCharArray()));

    }
}