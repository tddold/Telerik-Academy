namespace MobilePhone
{
    using System;

    class Phones
    {
        static void Main()
        {
            GSM phoneIPhone4S = new GSM();

            phoneIPhone4S.Model = "iPhone 4S";
            phoneIPhone4S.Manufacturer = "Apple";
            phoneIPhone4S.Owner = "Pesho";
            phoneIPhone4S.Price = 1024M;

            GSM phoneIPhone6Pluse = new GSM("iPhone6Plus", "Apple", "Gosho", 100);

            GSMTest iPhone = new GSMTest();
            iPhone.DisplayGSMs();
            //iPhone.IPhone4SInfo();

            GSMCallHistoryTest phoneIPhone6 = new GSMCallHistoryTest();

            PrintSeparateLine();
            Console.WriteLine(phoneIPhone4S);
            PrintSeparateLine();

            PrintSeparateLine();
            Console.WriteLine(phoneIPhone6Pluse);
            PrintSeparateLine();

            PrintSeparateLine();
            Console.WriteLine(phoneIPhone6);
            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
