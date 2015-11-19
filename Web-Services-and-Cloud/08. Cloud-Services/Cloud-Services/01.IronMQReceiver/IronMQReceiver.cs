namespace _01.IronMQReceiver
{
    using IronMQ;
    using IronMQ.Data;
    using System;
    using System.Threading;

    public class IronMQReceiver
    {
        public static void Main()
        {
            var client = new Client("564a487873d0cd00060000d7", "lCCnHWyU9L50RzrjEK0L");
            var queue = client.Queue("Homework");
            Console.WriteLine("Listening for new messages from IronMQ server:");

            while (true)
            {
                Message msg = queue.Get();
                if (msg != null)
                {
                    Console.WriteLine("ID {0} : {1}", msg.Id, msg.Body);
                    queue.DeleteMessage(msg);
                }

                Thread.Sleep(100);
            }
        }
    }
}
