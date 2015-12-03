namespace Matches
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Start
    {
        class Hash
        {
            private const ulong Base1 = 127;
            private const ulong Base2 = 257;
            private const ulong Mod = 1000000033;

            private static ulong[] powers1;
            private static ulong[] powers2;

            public Hash(string str)
            {
                this.Value1 = 0;
                this.Value2 = 0;

                foreach (char c in str)
                {
                    this.Add(c);
                }
            }

            public ulong Value1 { get; private set; }

            public ulong Value2 { get; private set; }

            public static void ComputePower(int n)
            {
                powers1 = new ulong[n + 1];
                powers2 = new ulong[n + 1];
                powers1[0] = 1;
                powers2[0] = 1;

                for (int i = 0; i < n; i++)
                {
                    powers1[i + 1] = powers1[i] * Base1 % Mod;
                    powers2[i + 1] = powers2[i] * Base2 % Mod;
                }
            }

            public void Add(char c)
            {
                this.Value1 = (this.Value1 * Base1 + c) % Mod;
                this.Value2 = (this.Value2 * Base2 + c) % Mod;
            }

            public void Remove(char c, int n)
            {
                this.Value1 = (Mod + this.Value1 - powers1[n] * c % Mod) % Mod;
                this.Value2 = (Mod + this.Value2 - powers2[n] * c % Mod) % Mod;
            }

        }

        static void MockInput()
        {
            string input = @"'-=input=-
put-=42;";

            Console.SetIn(new StringReader(input));
        }
        public static void Main()
        {
            // MockInput();

            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int maxlent = Solve(str1, str2);
            Console.WriteLine(maxlent);
        }

        private static int Solve(string str1, string str2)
        {
            int left = 0;
            int right = Math.Min(str1.Length, str2.Length);
            Hash.ComputePower(Math.Min(str1.Length, str2.Length));

            while (left < right)
            {
                int middle = (left + right) / 2;

                bool hasFoundMatches = Check(str1, str2, middle);

                if (hasFoundMatches)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            return right - 1;
        }

        private static bool Check(string str1, string str2, int lenght)
        {
            var hash1 = new Hash(str1.Substring(0, lenght));
            var hashes1 = new HashSet<ulong>();
            var hashes2 = new HashSet<ulong>();

            hashes1.Add(hash1.Value1);
            hashes2.Add(hash1.Value2);

            int n = str1.Length;

            for (int i = 0; i < n - lenght; i++)
            {
                hash1.Add(str1[lenght + i]);
                hash1.Remove(str1[i], lenght);

                hashes1.Add(hash1.Value1);
                hashes2.Add(hash1.Value2);
            }


            var hash2 = new Hash(str2.Substring(0, lenght));
            if (hashes1.Contains(hash2.Value1) &&
                hashes2.Contains(hash2.Value2))
            {
                return true;
            }

            n = str2.Length;
            for (int i = 0; i < n - lenght; i++)
            {
                hash2.Add(str2[lenght + i]);
                hash2.Remove(str2[i], lenght);

                if (hashes1.Contains(hash2.Value1) &&
                 hashes2.Contains(hash2.Value2))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
