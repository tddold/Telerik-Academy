using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Number_Of_Occurences
{
    public class NumberOfOccurences
    {
        public static void Main()
        {
            var numbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var countNumbers = FindeTimesOfOccursNumbers(numbers);

        }

        private static Dictionary<int, int> FindeTimesOfOccursNumbers(IList<int> numbers)
        {
            var dictionary = new Dictionary<int, int>();

            return dictionary;
        }
    }
}
