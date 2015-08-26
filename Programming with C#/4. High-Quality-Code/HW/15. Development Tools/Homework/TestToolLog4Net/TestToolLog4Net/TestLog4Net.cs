namespace TestToolLog4Net
{
    using System;

    using log4net;
    using log4net.Config;
    public class TestLog4Net
    {
        public static void Main()
        {
            BasicConfigurator.Configure();
            ILog Log = LogManager.GetLogger(typeof(TestLog4Net));
            Log.Info("Info Log4Net message.");
            Log.Warn("Warm Log4Net message.");
            Log.Error("Error Log4Net  message.");
            Log.Fatal("Fatal Log4Net message");

            Console.WriteLine("[Pres any key to exit.]");
            Console.ReadKey();
        }
    }
}
