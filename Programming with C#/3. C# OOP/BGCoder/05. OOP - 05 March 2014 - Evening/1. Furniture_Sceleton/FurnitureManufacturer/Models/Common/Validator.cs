namespace FurnitureManufacturer.Models.Common
{
    using System;

    public static class Validator
    {
        public static void CheckIfStringIsNullOrEmptyOrMinLenght(string text, int minLenght = 0, string message = null)
        {
            if (string.IsNullOrEmpty(text) || text.Length < minLenght)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void CheckIfPriceOrHightIsNull(decimal number, decimal minNumber, string message = null)
        {
            if (number <= minNumber)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}
