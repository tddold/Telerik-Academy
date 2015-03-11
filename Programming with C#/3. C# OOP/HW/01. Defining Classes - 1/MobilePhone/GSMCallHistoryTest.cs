namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class GSMCallHistoryTest
    {
        public void CallTest()
        {
            GSM phoneIPhone6 = new GSM("iPhone6", "Apple");

            // add calls
            phoneIPhone6.AddCall("112", 120);
            phoneIPhone6.AddCall("123456", 360);
            phoneIPhone6.AddCall("987654", 60);

            Console.WriteLine("Calls");
            PrintInfo(phoneIPhone6);

            // total price
            decimal callInfo = phoneIPhone6.CalculateTotalCallPrice(GSM.PricePerMinute);
            Console.Write("\nTotal call price: ");
            Console.WriteLine("{0} lv", callInfo);

            // delete calls
            Console.WriteLine("\nLongest call was removed.");
            int index = FindeLognesCall(phoneIPhone6);
            phoneIPhone6.DeleteCall(index);
            callInfo = phoneIPhone6.CalculateTotalCallPrice(GSM.PricePerMinute);
            Console.WriteLine("Total call price after remove lognes call: {0} lv", callInfo);

            Console.WriteLine("\nCalls info after delete call from call history:");
            PrintInfo(phoneIPhone6);

            // clear calls
            phoneIPhone6.ClearCall();
            Console.WriteLine("\nClear all calls\n");
            PrintInfo(phoneIPhone6);
        }

        private static int FindeLognesCall(GSM phoneIPhone6)
        {
            uint lognes = 0;
            int index = 0;
            for (int i = 0; i < phoneIPhone6.CallHistory.Count; i++)
            {
                if (lognes < phoneIPhone6.CallHistory[i].Duration)
                {
                    lognes = phoneIPhone6.CallHistory[i].Duration;
                    index = i;
                }
            }

            return index;
        }

        private static void PrintInfo(GSM phoneIPhone6)
        {
            foreach (var call in phoneIPhone6.CallHistory)
            {
                Console.WriteLine("Date : {0} , Duration {1, 3}, Number : {2}", call.CallDate, call.Duration, call.DialledNumber);
            }
        }
    }
}
