namespace _01.IronMQSender
{
    using IronMQ;
    using System;

    public class IronMQSender
    {
        public static void Main()
        {
            var client = new Client("564a487873d0cd00060000d7", "lCCnHWyU9L50RzrjEK0L");
            var queue = client.Queue("Homework");
            Console.WriteLine("Enter messages to be sent to the IronMQ server:");

            while (true)
            {
                string msg = Console.ReadLine();
                queue.Push(msg);
                Console.WriteLine("Message sent to the IronMQ server.");
            }
        }
    }
}
