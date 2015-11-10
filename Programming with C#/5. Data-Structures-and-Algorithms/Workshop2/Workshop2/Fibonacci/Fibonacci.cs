namespace Fibonacci
{
    using System;

    public class Fibonacci
    {
        static long[] memo;
        private const int Mod = 1000000007;

        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            var a = new Matrix(1, 1, 1, 0);

           // memo = new long[n + 1];

            // Console.WriteLine(FibonacciNumbers(n));

            Console.WriteLine(PowMod(a, n).Table[0, 1]);
        }

        //private static long FibonacciNumbers(long n)
        //{

        //    if (memo[n] != 0)
        //    {
        //        return memo[n];
        //    }

        //    if (n == 1 || n == 2)
        //    {
        //        return 1;
        //    }

        //    long number = FibonacciNumbers(n - 1) + FibonacciNumbers(n - 2);
        //    number %= Mod;
        //    memo[n] = number;
        //    return number;
        //}

        private static Matrix PowMod(Matrix a, long p)
        {
            if (p == 1)
            {
                return a;
            }

            if (p % 2 == 1)
            {
                return new Matrix(PowMod(a, p - 1), a);
            }

            a = PowMod(a, p / 2);
            return new Matrix(a, a);
        }

        public class Matrix
        {
            public Matrix(long a, long b, long c, long d)
            {
                this.Table = new long[2, 2];

                this.Table[0, 0] = a;
                this.Table[0, 1] = b;
                this.Table[1, 0] = c;
                this.Table[1, 1] = d;
            }

            public Matrix(Matrix A, Matrix B)
            {
                this.Table = new long[2, 2];

                this.Table[0, 0] = A.Table[0, 0] * B.Table[0, 0]
                                 + A.Table[0, 1] * B.Table[1, 0];
                this.Table[0, 1] = A.Table[0, 0] * B.Table[0, 1]
                                 + A.Table[0, 1] * B.Table[1, 1];
                this.Table[1, 0] = A.Table[1, 0] * B.Table[0, 0]
                                 + A.Table[1, 1] * B.Table[1, 0];
                this.Table[1, 1] = A.Table[1, 0] * B.Table[0, 1]
                                 + A.Table[1, 1] * B.Table[1, 1];

                this.Table[0, 0] %= Mod;
                this.Table[0, 1] %= Mod;
                this.Table[1, 0] %= Mod;
                this.Table[1, 1] %= Mod;
            }

            public long[,] Table { get; set; }
        }
    }
}
