using System;

class NightmareOnCodeStreet
{
    static void Main()
    {

        string number = Console.ReadLine();
        // int pos = 0;
        int counter = 0;
        int result = 0;


        for (int i = 1; i < number.Length; i++)
        {
            if ((char) number[i] >= 48 && (char) number[i] <= 57)
            {
                result += ((char) (number[i]) - 48);
                counter++;
            }
            else if (number[i] == ' ')
            {
                result += ((char) (number[i]) - 32);
                counter++;
            }
            i++;
        }

        //foreach (char n in number)
        //{
        //    if (pos % 2 != 0)
        //    {
        //        if (n >= 48 && n <= 57)
        //        {
        //            result += (n - 48);
        //            counter++;
        //        }
        //        else if (n == ' ')
        //        {
        //            result += n - 32;
        //            counter++;
        //        }
        //    }
        //    pos++;
        //}

        Console.WriteLine("{0} {1}", counter, result);
    }
}