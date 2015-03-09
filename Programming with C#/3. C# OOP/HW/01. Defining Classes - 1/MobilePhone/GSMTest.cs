namespace MobilePhone
{
    using System;

    public class GSMTest
    {
        // making an array with empty GSM classes in it
        private GSM[] phones = new GSM[3] { new GSM(), new GSM(), new GSM() };

        public void DisplayGSMs()
        {
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }
        }

        public void IPhone4SInfo()
        {
            GSM iPhone4SInfo = new GSM();
            Console.WriteLine(iPhone4SInfo.IPhone4S.ToString());
        }
    }
}
