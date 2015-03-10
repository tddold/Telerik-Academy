namespace MobilePhone
{
    using System;

    public class GSMCallHistoryTest
    {      

        public void CallTest()
        {
            GSM phoneIPhone6 = new GSM("iPhone6", "Apple", "Ivan Ivanow", 1049);

            // add calls
            phoneIPhone6.AddCall("112", 120);
            phoneIPhone6.AddCall("123456", 360);
            phoneIPhone6.AddCall("987654", 60);




            Console.WriteLine("Calls");
            foreach (var call in phoneIPhone6.CallHistory)
            {
                Console.WriteLine("Date : {0} , Duration {1}, Number : {2}",call.CallDate,call.Duration,call.DialledNumber);
                //uint totalPrice = phoneIPhone6.CalculateTotalCallPrice((decimal) 0.37);
            }
        }
    }
}
