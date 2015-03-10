namespace MobilePhone
{
    using System;

    class Phones
    {
        static void Main()
        {
            GSMTest testGsm = new GSMTest();            

            GSMCallHistoryTest phoneIPhone6 = new GSMCallHistoryTest();

            PrintSeparateLine();
            Console.WriteLine("GSM Test - information about the GSMs in the array");
            PrintSeparateLine();
            testGsm.DisplayGSMs();
           
            PrintSeparateLine();
            Console.WriteLine("GSM Test - information about the static property IPhone4S");
            PrintSeparateLine();
            testGsm.IPhone4SInfo();
            PrintSeparateLine();

            Console.WriteLine("Call history test");
            PrintSeparateLine();
            phoneIPhone6.CallTest();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
