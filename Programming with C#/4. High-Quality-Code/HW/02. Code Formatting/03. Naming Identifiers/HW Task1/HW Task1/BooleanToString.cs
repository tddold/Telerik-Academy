using System;

class BooleanToString
{
    const int MaxCount = 6;
    class Converter
    {
        void ConvertBooleanToString(bool input)
        {
            string inputToString = input.ToString();
            Console.WriteLine(inputToString);
        }
    }
    public static void CreateConverter()
    {
        var converter =   new Converter();
        converter.ConvertBooleanToString(true);
    }
}