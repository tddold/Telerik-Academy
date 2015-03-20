/*Problem 8.* Events
 * Read in MSDN about the keyword event in C# and how to publish events.
 * Re-implement the above using .NET events and following the best practices.*/

namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class TestEvents
    {      
        public static void Main()
        {
            Publisher eventPublisher = new Publisher();

            //create subscribers for the event
            Subscriber sub1 = new Subscriber("Pesho", eventPublisher); 
            Subscriber sub2 = new Subscriber("Gosho", eventPublisher);

            //sample event is raised by the publisher and handled by the subscribers
            eventPublisher.RaiseSampleEvent();

            // Keep the console window open
            Console.WriteLine("Press Enter to close this window.");
            Console.ReadLine();
        }
    }
}
