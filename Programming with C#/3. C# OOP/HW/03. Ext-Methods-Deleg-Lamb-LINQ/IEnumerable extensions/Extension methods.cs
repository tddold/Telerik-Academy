namespace IEnumerable_extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;   

    public static class Extension_methods
    {
        public static T Sum<T>(this IEnumerable<T> source)
        {
            CheckIsColectionIsEmpty<T>(source);

            // making it dynamic because otherwise
            // i cant use it in generics
            dynamic result = 0;

            foreach (var item in source)
            {
                result += item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> source)
        {
            CheckIsColectionIsEmpty<T>(source);

            // making it dynamic because otherwise
            // i cant use it in generics
            dynamic result = 1;

            foreach (var item in source)
            {
                result *= item;
            }

            return result;
        }

        public static double Average<T>(this IEnumerable<T> source)
        {
            CheckIsColectionIsEmpty<T>(source);

            double result = 0;

            foreach (var item in source)
            {
                result += (dynamic)item;
            }

            return result / (dynamic)source.Count();
        }

        public static T Min<T>(this IEnumerable<T> source)
        {
            return MinMax(source, false);
        }

        public static T Max<T>(this IEnumerable<T> source)
        {
            return MinMax(source, true);
        }

        private static T MinMax<T>(IEnumerable<T> collection, bool value)
        {
            CheckIsColectionIsEmpty<T>(collection);

            T best = collection.First();

            foreach (var element in collection)
            {
                if (value)
                {
                    if (best < (dynamic)element)
                    {
                        best = element;
                    }
                }
                else
                {
                    if (best > (dynamic)element)
                    {
                        best = element;
                    }
                }
            }

            return best;
        }

        private static void CheckIsColectionIsEmpty<T>(IEnumerable<T> source)
        {
            if (source.Count() == 0)
            {
                throw new ArgumentException("The colection is empty!");
            }
        }
    }
}
