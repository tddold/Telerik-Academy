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
            testGsm.GSMSpecs();
           
            PrintSeparateLine();
            Console.WriteLine("GSM Test - information about the static property IPhone4S");
            PrintSeparateLine();
            testGsm.GSMSpecsToString();
            PrintSeparateLine();

            Console.WriteLine("Call history test");
            PrintSeparateLine();
            phoneIPhone6.CallTest();
            PrintSeparateLine();
        }

        public static void PrintSeparateLine()
        {
            Console.WriteLine(new string('-', 40));
        }
    }
}
