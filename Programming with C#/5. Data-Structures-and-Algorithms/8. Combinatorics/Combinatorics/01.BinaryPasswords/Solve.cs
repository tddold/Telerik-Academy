namespace BinaryPasswords
{
    using System;
    using System.Linq;

    public class Solve
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pow = input
                .Where(i => i == '*')
                .Count();

            long baseN = 2;
            long result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= baseN;
            }

            Console.WriteLine(result);
        }
    }
}
