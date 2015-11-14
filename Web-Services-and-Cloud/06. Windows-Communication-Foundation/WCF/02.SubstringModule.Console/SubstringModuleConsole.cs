namespace SubstringModule.Console
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using SubstringModule.Console.ServiceSubstringModule;
    using SubstringModule.Service;

    public class SubstringModuleConsole
    {
        private const string HostUrl = "http://localhost:8733/Design_Time_Addresses/SubstringModule.Services/";

        internal static void Main()
        {
            try
            {
                using (var selfHost = HostSubstringModuleService())
                {
                    selfHost.Open();
                    GetNumberOfSubstrings();
                }
            }
            catch (Exception)
            {
                // Use already opened host
                GetNumberOfSubstrings();
            }
        }

        private static void GetNumberOfSubstrings()
        {
            var client = new SubstringServiceClient();

            string text = "alalal";
            string substring = "al";
            int numberOfSubstrings = client.GetNumberOfSubstrings(text, substring);
            System.Console.WriteLine("Text: {0} | Substring: {1} -> number of substrings: {2}", text, substring, numberOfSubstrings);
        }

        private static ServiceHost HostSubstringModuleService()
        {
            var serviceAddresses = new Uri(HostUrl);
            var smb = new ServiceMetadataBehavior();
            smb.HttpsGetEnabled = true;

            var selfHost = new ServiceHost(typeof(SubstringService), serviceAddresses);
            selfHost.Description.Behaviors.Add(smb);

            return selfHost;
        }
    }
}
