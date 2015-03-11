namespace MobilePhone
{
    using System;

    public class GSMTest
    {
        // making an array with empty GSM classes in it
        private GSM[] phones = new GSM[3] {
            new GSM("iPhone5C", "Apple", "Ivan Ivanov", 700, 
                new Battery("1510mAh", 250, 10, BatteryType.LiPo),
                new Display(4.0, 16000000)),
            new GSM("iPhone6", "Apple", "Pesho Peshev", 1500,
                new Battery("1810mAh", 250, 10, BatteryType.LiPo),
                new Display(4.7, 16000000)), 
            new GSM("iPhone6Pluse", "Apple", "Asen Asenov", 1800,
                new Battery("2915mAh", 384, 24, BatteryType.LiPo),
                new Display(5.5, 16000000)) };

        public void GSMSpecs()
        {
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }
        }

        public void GSMSpecsToString()
        {
            Console.WriteLine(GSM.iPhone4S.ToString());
        }
    }
}
 