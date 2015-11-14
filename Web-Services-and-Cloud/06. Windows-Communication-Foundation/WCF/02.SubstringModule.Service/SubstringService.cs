namespace SubstringModule.Service
{
    public class SubstringService : ISubstringService
    {
        public int GetNumberOfSubstrings(string text, string substring)
        {
            int count = 0;
            int index = text.IndexOf(substring, System.StringComparison.Ordinal);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(substring, index + 1, System.StringComparison.Ordinal);
            }

            return count;
        }
    }
}
