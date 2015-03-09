namespace MobilePhone
{
    using System;

    class Phones
    {
        static void Main()
        {
            GSM phone = new GSM();

            phone.Model = "iPhone 6 Pluse";
            phone.Manufacturer = "Apple";
            phone.Owner = "Pesho";
            phone.Price = 1024M;

            PrintSeparateLine();
            Console.WriteLine(phone);
            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
