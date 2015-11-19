﻿namespace PubNup
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            // Start the HTML5 Pubnub client
            Process.Start("..\\..\\Receiver.html");

            Thread.Sleep(2000);

            PubnubAPI pubnub = new PubnubAPI(
                "pub-c-ebd958d0-e2fd-4aab-a2fc-7d31e8995644",
                "sub-c-44a39b0c-886a-11e5-84ee-0619f8945a4f",
                "sec-c-MWVkYjQxY2EtYTEzYi00OTBmLWJmNzktYmM5OWI2OWE4YzU4",
                true
            );
            string channel = "Chat";

            // Publish a sample message to Pubnub
            List<object> publishResult = pubnub.Publish(channel, "Hello Pubnub!");
            Console.WriteLine(
                "Publish Success: " + publishResult[0].ToString() + "\n" +
                "Publish Info: " + publishResult[1]
            );

            // Show PubNub server time
            object serverTime = pubnub.Time();
            Console.WriteLine("Server Time: " + serverTime.ToString());

            // Subscribe for receiving messages (in a background task to avoid blocking)
            Task t = new Task(
                 () =>
                 pubnub.Subscribe(
                     channel,
                     delegate (object message)
                     {
                         Console.WriteLine("Received Message -> '" + message + "'");
                         return true;
                     }
                 )
             );
            t.Start();

            // Read messages from the console and publish them to Pubnub
            while (true)
            {
                Console.Write("Enter a message to be sent to Pubnub: ");
                string msg = Console.ReadLine();
                pubnub.Publish(channel, msg);
                Console.WriteLine("Message {0} sent.", msg);
            }
        }
    }
}
