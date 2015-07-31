/*
 Task 3. Compare advanced Maths

Write a program to compare the performance of:
square root, natural logarithm, sinus
for the values:
float, double and decimal
 */

namespace Performance
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    internal class MathAdvancedPerformace
    {
        private const int Count = 5000000;
        private const int SquareRootPower = 2;

        private static readonly Stopwatch Sw = new Stopwatch();
        private static readonly Random Rnd = new Random();

        private static void Main()
        {
            FloarTest();
            DoubleTest();
            DecimalTect();
        }

        private static void FloarTest()
        {
            float result = 0f;
            Sw.Start();

            for (int i = 0; i < Count; i++)
            {
                result = (float)Math.Pow(GetRandomDouble(), SquareRootPower); // Square root
                result = (float)Math.Log10(GetRandomDouble()); // Natural Log
                result = (float)Math.Sin(GetRandomDouble()); // Sinus
            }

            Sw.Stop();
            Console.WriteLine("Float test passed: " + Sw.Elapsed);
            Sw.Reset();
        }

        private static void DoubleTest()
        {
            double result = 0d;
            Sw.Start();

            for (int i = 0; i < Count; i++)
            {
                result = Math.Pow(GetRandomDouble(), SquareRootPower); // Square root
                result = Math.Log10(GetRandomDouble()); // Natural Log
                result = Math.Sin(GetRandomDouble()); // Sinus
            }

            Sw.Stop();
            Console.WriteLine("Float test passed: " + Sw.Elapsed);
            Sw.Reset();
        }

        private static void DecimalTect()
        {
            decimal result = 0m;
            Sw.Start();

            for (int i = 0; i < Count; i++)
            {
                result = (decimal)Math.Pow(GetRandomDouble(), SquareRootPower); // Square root
                result = (decimal)Math.Log10(GetRandomDouble()); // Natural Log
                result = (decimal)Math.Sin(GetRandomDouble()); // Sinus
            }

            Sw.Stop();
            Console.WriteLine("Float test passed: " + Sw.Elapsed);
            Sw.Reset();
        }

        private static double GetRandomDouble()
        {
            var randomDouble = Rnd.NextDouble() * Rnd.Next(1, int.MaxValue);
            return randomDouble;
        }
    }
}
