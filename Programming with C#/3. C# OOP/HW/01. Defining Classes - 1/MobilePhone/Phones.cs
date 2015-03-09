namespace MobilePhone
{
    using System;

    class Phones
    {
        static void Main()
        {
            GSM phone = new GSM();

            phone.Model = "iPhone 4S";
            phone.Manufacturer = "Apple";
            phone.Owner = "Pesho";
            phone.Price = 1024M;

            GSM phone2 = new GSM("iPhone6Plus", "Apple", "Gosho", 100);

            GSMTest iPhone = new GSMTest();
            iPhone.DisplayGSMs();
            //iPhone.IPhone4SInfo();

            PrintSeparateLine();
            Console.WriteLine(phone);
            PrintSeparateLine();

            PrintSeparateLine();
            Console.WriteLine(phone2);
            PrintSeparateLine();

            PrintSeparateLine();
            Console.WriteLine(iPhone);
            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
