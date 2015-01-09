using System;

//Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.


class IndexElementOfGivenWord
{
    static void Main()
    {
        //input
        Console.Write("Enter word for test:");
        string testWord = Console.ReadLine();
        char[] arrayTestWord = testWord.ToCharArray();
        //char[] arrayTestWord = new char[testWord.Length];
        //for (int i = 0; i < arrayTestWord.Length; i++)
        //{
        //    arrayTestWord[i] = testWord[i];
        //}

        //check input word to array
        Console.Write(string.Join(",", arrayTestWord));
        Console.WriteLine();
        Console.WriteLine((int)arrayTestWord[0] + "," + (int)arrayTestWord[1] + "," + (int)arrayTestWord[2] + "," + (int)arrayTestWord[3] + ",");

        char[] arrayAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        int start = 0;
        int end = arrayAlphabet.Length - 1;
        int mid = (start + end) / 2;
        int[] arrayIndexWord = new int[arrayTestWord.Length];

        //logic
        for (int i = 0; i < arrayTestWord.Length; i++)
        {
            while (start <= end)
            {
                mid = (start + end) / 2;

                if ((int)arrayAlphabet[mid] == (int)arrayTestWord[i])
                {
                    arrayIndexWord[i] = mid;
                    break;
                }
                else if ((int)arrayAlphabet[mid] > (int)arrayTestWord[i])
                {
                    end = mid - 1;
                }
                else if ((int)arrayAlphabet[mid] < (int)arrayTestWord[i])
                {
                    start = mid + 1;
                }
            }
            start = 0;
            end = arrayAlphabet.Length - 1;
            mid = (start + end) / 2;
        }
        //output
        Console.WriteLine(string.Join(",", arrayIndexWord));
    }
}