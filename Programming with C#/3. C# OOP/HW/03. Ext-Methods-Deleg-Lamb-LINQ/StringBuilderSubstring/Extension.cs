namespace StringBuilderSubstring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int lenght)
        {
            if (index < 0 || index >= sb.Length)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }

            if (lenght < 0)
            {
                throw new ArgumentException("Lenght mast be > 0!");
            }

            if (index + lenght >= sb.Length)
            {
                throw new ArgumentException("The lenght of substing is bigger!");
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < lenght; i++)
            {
                result.Append(sb[index + i]);
            }

            return result;
        }
    }
}
