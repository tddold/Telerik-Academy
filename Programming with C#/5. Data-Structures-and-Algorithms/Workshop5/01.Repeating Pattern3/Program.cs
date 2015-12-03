namespace _01.Repeating_Pattern3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int n = text.Length / 2;
            text = text + text;

            int[] fl = new int[n + 1];

            fl[0] = -1;
            fl[1] = 0;

            for (int i = 0; i <n; i++)
            {
                int j = fl[i];

                while (j >= 0 && text[i] != text[j])
                {
                    j = fl[j];
                }

                fl[i + 1] = j + 1;
            }

            int matched = 0;
            for (int i = 1; i < text.Length; i++)
            {
                while (matched >= 0 && text[i] != text[matched])
                {
                    matched = fl[matched];
                }

                matched++;

                if (matched == n)
                {
                    Console.WriteLine(text.Substring(0, i - (n - 1)));
                    break;
                }
            }
        }
    }
}
