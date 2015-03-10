namespace MobilePhone
{
    using System;

    public class GSMTest
    {
        // making an array with empty GSM classes in it
        private GSM[] phones = new GSM[3] { new GSM("iPhone5C", "Apple", "Ivan Ivanov", 700), new GSM("iPhone6", "Apple", "Pesho Peshev", 1500), new GSM("iPhone6Pluse", "Apple", "Asen Asenov", 1800) };

        public void DisplayGSMs()
        {
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }
        }

        public void IPhone4SInfo()
        {
            Console.WriteLine(GSM.iPhone4S.ToString());
        }
    }
}
 