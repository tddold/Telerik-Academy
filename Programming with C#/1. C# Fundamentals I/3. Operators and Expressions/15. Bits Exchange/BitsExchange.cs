/*Problem 15.* Bits Exchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.*/

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Title = "Bits Exchange";

        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Binay representation input number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));

        int lowerPos = 3;
        int hightPos = 24;
        while (lowerPos >= 3 && lowerPos <= 5)
        {
            uint exchengeLowerPosValue;
            uint exchengeHightPosValue;

            uint checkLowerPosValue = (number >> lowerPos) & 1;
            uint checkHightPosValue = (number >> hightPos) & 1;

            if (checkLowerPosValue == 1)
            {
                exchengeHightPosValue = checkLowerPosValue << hightPos;
                number = number | exchengeHightPosValue;
            }
            else
            {
                exchengeHightPosValue = (uint)~(1 << hightPos);
                number = number & exchengeHightPosValue;
            }

            if (checkHightPosValue == 1)
            {
                exchengeLowerPosValue = checkHightPosValue << lowerPos;
                number = number | exchengeLowerPosValue;
            }
            else
            {
                exchengeLowerPosValue = (uint)~(1 << lowerPos);
                number = number & exchengeLowerPosValue;
            }

            lowerPos++;
            hightPos++;
        }

        Console.WriteLine("Binary representation result is  : {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The result is --> {0}", number);
    }


}