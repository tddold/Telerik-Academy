namespace RabinKarpHash
{
    using System;
    using System.IO;

    class Hash
    {
        private const ulong BASE = 257;
        private const ulong MOD = 1000000033;

        private static ulong[] powers;

        public static void ComputePowers(int n)
        {
            powers = new ulong[n + 1];
            powers[0] = 1;

            for (int i = 0; i < n; i++)
            {
                powers[i + 1] = powers[i] * BASE % MOD;
            }
        }

        public ulong Value { get; private set; }

        public Hash(string str)
        {
            this.Value = 0;

            foreach (char c in str)
            {
                this.Add(c);
            }
        }

        public void Add(char c)
        {
            this.Value = (this.Value * BASE + c) % MOD;
        }

        public void Remove(char c, int n)
        {
            this.Value = (MOD + this.Value - powers[n] * c % MOD) % MOD;
        }
    }



    class StartUp
    {
        static void MockInput()
        {
            string input = @"'-=input=-
put-=42;";

            Console.SetIn(new StringReader(input));
        }

        static void Main()
        {
            // MockInput();

            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            int n = text.Length;
            int m = pattern.Length;

            if (m > n)
            {
                return;
            }

            Hash.ComputePowers(m);

            Hash hpattern = new Hash(pattern);
            Hash hwindow = new Hash(text.Substring(0, m));

            if (hpattern.Value == hwindow.Value)
            {
                Console.WriteLine("Math at 0");
            }

            for (int i = 1; i <= n - m; i++)
            {
                hwindow.Add(text[i + m - 1]);
                hwindow.Remove(text[i - 1], m);

                if (hpattern.Value == hwindow.Value)
                {
                    Console.WriteLine("Math at {0}", i);
                }
            }
        }
    }
}
