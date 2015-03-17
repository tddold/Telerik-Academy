namespace ALotOfFeatures.Extensions
{
    using System.Text;

    public static class StringExtensions
    {
        public static string AggregateWith(this string originalString, int count)
        {
            var result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(originalString);
            }

            return result.ToString();
        }

        public static string AggregateWith(this string originalString, int count, char separator)
        {
            var result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(originalString);
                if (i != count - 1)
                {
                    result.Append(separator);
                }
            }

            return result.ToString();
        }
    }
}
