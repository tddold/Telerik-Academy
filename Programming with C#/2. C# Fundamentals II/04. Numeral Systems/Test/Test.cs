using System;

namespace _01.Decimal_to_Binary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Decimal: ");
            //int decimalNumber = int.Parse(Console.ReadLine());

            //int remainder;
            //string result = string.Empty;
            //while (decimalNumber > 0)
            //{
            //    remainder = decimalNumber % 2;
            //    decimalNumber /= 2;
            //    result = remainder.ToString() + result;
            //}
            //Console.WriteLine("Binary:  {0}", result);

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                int tmp = i;
                int spasceNum = number-i;

                string star = new string('*', i);
                string space = new string(' ', spasceNum);
                char tree = '|';
                Console.Write(space);
                Console.Write(star);
                Console.Write(tree);
                Console.Write(star);
                Console.Write(space);
                Console.WriteLine();
            }
        }
    }
}