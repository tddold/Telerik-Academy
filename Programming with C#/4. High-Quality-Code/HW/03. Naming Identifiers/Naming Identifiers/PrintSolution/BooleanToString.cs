namespace PrintSolution
{
    using System;

    public class BooleanToString
    {
        private const int MaxCount = 6;

        public static void CreateConverter()
        {
            var converter = new Converter();
            converter.BooleanToString(true);
        }
    }
}
