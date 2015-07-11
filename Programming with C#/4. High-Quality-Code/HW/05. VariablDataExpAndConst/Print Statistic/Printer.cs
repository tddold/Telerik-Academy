namespace Print_Statistic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Printer
    {
        public void PrintStatistic(double[] numbers, int count)
        {
            double largestNumber = double.MinValue;
            double smallestNumber = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] > largestNumber)
                {
                    largestNumber = numbers[i];
                }

                if (numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                }

                sum += numbers[i];
            }

            double average = sum / count;

            this.PrintMax(largestNumber);
            this.PrintMin(smallestNumber);
            this.PrintAverage(average);
        }

        private void PrintMin(double smallestNumber)
        {
            Console.WriteLine("The smallest number is {0}.", smallestNumber);
        }

        private void PrintMax(double largestNumber)
        {
            Console.WriteLine("The largest number is {0}.", largestNumber);
        }

        private void PrintAverage(double average)
        {
            Console.WriteLine("The average of the numbers is {0}.", average);
        }
    }
}
