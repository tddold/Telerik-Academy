/*Problem 7. Timer
 * Using delegates write a class Timer that can execute certain method at each t seconds.*/

namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public delegate void DelegateTSeconds();

    public class TestTimer
    {
        static int seconds;
        public static void TestMethod()
        {
            // I m making a test method just to see that the method is running every second
            Console.WriteLine("This method happens each \"{0}\" seconds using delegates !!!!!!", seconds);            
        }

        public static void Main()
        {
            Console.Write("Enter the each \"t\" seconds you want the method to be runned : ");
            seconds = int.Parse(Console.ReadLine());
            Tester t = new Tester(seconds);
            t.Run();
        }
    }
}
