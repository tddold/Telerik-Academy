/*
 Task 2. Compare simple Maths

Write a program to compare the performance of:
add, subtract, increment, multiply, divide
for the values:
int, long, float, double and decimal
 */

namespace Performance
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    internal class MathOperationsPerformance
    {
        private const int Count = 10000000;

        private static readonly Stopwatch Sw = new Stopwatch();
        private static readonly Random Rnd = new Random();
        
        private static void Main()
        {
            IntTest();
            LongTest();
            FloatTest();
            DoubleTest();
            DecimalTest();
        }

        private static void IntTest()
        {
            int result = GetRandomValue();
            Sw.Start();

            for (int i = 0; i < Count; i++)
            {
                unchecked
                {
                    result += GetRandomValue(); // Add
                    result -= GetRandomValue(); // Subtract
                    result++; // Increment
                    result *= GetRandomValue(); // Multiply
                    result /= GetRandomValue(); // Divide
                }
            }

            Sw.Stop();
            Console.WriteLine("Int test passed. Total elapsed: " + Sw.Elapsed);
            Sw.Reset();
        }

        private static void LongTest()
        {
            long result = GetRandomValue();
            Sw.Start();

            for (int i = 0; i < Count; i++)
            {
                unchecked
                {
                    result += GetRandomValue(); // Add
                    result -= GetRandomValue(); // Subtract
                    result++; // Increment
                    result *= GetRandomValue(); // Multiply
                    result /= GetRandomValue(); // Divide
                }
            }

            Sw.Stop();
            Console.WriteLine("Long test passed. Total elapsed: " + Sw.Elapsed);
            Sw.Reset();
        }

        private static void FloatTest()
        {
            float result = GetRandomValue();
            Sw.Start();

            for (int i = 0; i < Count; i++)
            {
                unchecked
                {
                    result += GetRandomValue(); // Add
                    result -= GetRandomValue(); // Subtract
                    result++; // Increment          
                    result *= GetRandomValue(); // Multiply
                    result /= GetRandomValue(); // Divide
                }
            }

            Sw.Stop();
            Console.WriteLine("Float test passed. Total elapsed: " + Sw.Elapsed);
            Sw.Reset();
        }

        private static void DoubleTest()
        {
            double result = GetRandomValue();
            Sw.Start();

            for (int i = 0; i < Count; i++)
            {
                unchecked
                {
                    result += GetRandomValue(); // Add
                    result -= GetRandomValue(); // Subtract
                    result++; // Increment          
                    result *= GetRandomValue(); // Multiply
                    result /= GetRandomValue(); // Divide
                }
            }

            Sw.Stop();
            Console.WriteLine("Double test passed. Total elapsed: " + Sw.Elapsed);
            Sw.Reset();
        }

        /// <summary>
        /// Problem: Cannot avoid overflow unchecked -> multiplying is skipped.
        /// </summary>
        private static void DecimalTest()
        {
            decimal result = GetRandomValue();
            Sw.Start();

            for (int i = 0; i < Count; i++)
            {
                unchecked
                {
                    result += GetRandomValue(); // Add
                    result -= GetRandomValue(); // Subtract
                    result++; // Increment
                    // result *= GetRandomValue(); // Multiply
                    result /= GetRandomValue(); // Divide
                }
            }

            Sw.Stop();
            Console.WriteLine("Decimal test passed. Total elapsed: " + Sw.Elapsed);
            Sw.Reset();
        }

        private static int GetRandomValue()
        {
            return Rnd.Next(1, int.MaxValue);
        }
    }
}
