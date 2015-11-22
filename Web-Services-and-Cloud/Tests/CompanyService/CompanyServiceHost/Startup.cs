namespace CompanyServiceHost
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using WcfCompanyService;

    class Startup
    {
        static void Main()
        {
            Uri serviceAddress = new Uri("http://localhost:1337/Company");
            var selfHost = new ServiceHost(typeof(CompanyService), serviceAddress);

            var smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);

            selfHost.Open();
            Console.WriteLine("Service start on: {0}", serviceAddress);
            Console.WriteLine("Pres enter to exit");
            Console.ReadLine();
        }
    }
}
