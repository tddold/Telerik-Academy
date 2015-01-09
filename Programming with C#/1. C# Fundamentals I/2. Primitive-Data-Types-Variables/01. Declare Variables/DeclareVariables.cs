// Problem 1. Declare Variables
// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class DeclareVariables
{
    static void Main()
    {
        Console.Title = "Variables";
        byte byteVar = 97;
        sbyte sbyteVar = -115;
        short shortVar = -10000;
        ushort ushortVar = 52130;
        uint uintVar = 4825932;

        Console.WriteLine("The type number is:");
        Console.WriteLine(new string('=', 40));
        Console.WriteLine("{0, 8} --> {1}", byteVar, byteVar.GetTypeCode());
        Console.WriteLine("{0, 8} --> {1}", sbyteVar, sbyteVar.GetTypeCode());
        Console.WriteLine("{0, 8} --> {1}", shortVar, shortVar.GetTypeCode());
        Console.WriteLine("{0, 8} --> {1}", ushortVar, ushortVar.GetTypeCode());
        Console.WriteLine("{0, 8} --> {1}", uintVar,  uintVar.GetTypeCode());
    }
}
