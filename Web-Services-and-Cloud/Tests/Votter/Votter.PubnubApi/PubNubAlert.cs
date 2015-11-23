namespace Votter.PubnubApi
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PubnubAlert
    {
        private const string PublishKey = "pub-c-dd2f112e-5678-40ab-83e5-9f78932acd02";
        private const string SubscribeKey = "sub-c-aa397582-3f4a-11e4-8c81-02ee2ddab7fe";
        private const string SecretKey = "sec-c-Yzg4N2JhOWMtMGVmYS00NmQ3LWE1YTMtNDY3NzcyYmM1MzE1";
        private const string Channel = "team-papaya";

        private PubnubAPI pubnub;

        public PubnubAlert()
        {
            this.pubnub = new PubnubAPI(PublishKey, SubscribeKey, SecretKey);
        }

        public void Start()
        {
            Process.Start(@"..\..\..\Votter.ConsoleClient\index.html");

            System.Threading.Thread.Sleep(2000);

            System.Threading.Tasks.Task t = new System.Threading.Tasks.Task(
            () =>
            this.pubnub.Subscribe(
                    Channel,
                    delegate(object message)
                    {
                        return true;
                    }
                )
            );
            t.Start();
        }

        public void PublishMessage(string message)
        {
            this.pubnub.Publish(Channel, message);
        }
    }
}
