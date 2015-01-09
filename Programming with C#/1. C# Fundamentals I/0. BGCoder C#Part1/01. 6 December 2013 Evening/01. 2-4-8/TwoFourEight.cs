using System;

class TwoFourEight
{
    static void Main()
    {
        ulong a = ulong.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        ulong c = ulong.Parse(Console.ReadLine());
        ulong r = 0;

        if (b == 2)
        {
            r = (ulong) (a % c);
        }
        else if (b == 4)
        {
            r = (ulong) (a + c);
        }
        else if (b == 8)
        {
            r = (ulong) (a) * (ulong) (c);

        }

        if (r % 4 == 0)
        {
            Console.WriteLine(r / 4);
        }
        else
        {
            Console.WriteLine(r % 4);
        }
        Console.WriteLine(r);
    }
}