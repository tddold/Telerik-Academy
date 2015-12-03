namespace _04.Palindromize
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            //Console.WriteLine(IsPalindrome("abbba"));
            //Console.WriteLine(IsPalindrome("a"));
            //Console.WriteLine(IsPalindrome("acca"));
            //Console.WriteLine(IsPalindrome("acxyca"));

            var str = Console.ReadLine();

            var answer = Palindromize(str);

            Console.WriteLine(answer);
        }

        private static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static string Palindromize(string str)
        {
            //if (IsPalindrome(str))
            //{
            //    return str;
            //}

            for (int numberOfChars = 0; numberOfChars < str.Length; numberOfChars++)
            {
                var firstIChar = str.Substring(0, numberOfChars).ToCharArray();
                Array.Reverse(firstIChar);
                var candidate = str + new string(firstIChar);

                if (IsPalindrome(candidate))
                {
                    return candidate;
                }
            }

            return string.Empty;
        }
    }
}
