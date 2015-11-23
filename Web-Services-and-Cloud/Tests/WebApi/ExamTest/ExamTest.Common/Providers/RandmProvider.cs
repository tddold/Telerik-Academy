namespace ExamTest.Common.Providers
{
    using System;

    public class RandmProvider : IRandomProvider
    {
        private static Random random = new Random();

        public int GetRandomNumber(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}