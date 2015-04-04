namespace WarMachines.Common
{
    using System;
    public static class Validator
    {
        public static void ChekIfNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string test, string message = null)
        {
            if (string.IsNullOrEmpty(test))
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
