namespace Dropbox
{
    using DropNet;
    using System;
    using System.Diagnostics;
    using System.IO;

    public class StartUp
    {
        private const string DropboxAppKey = "v0ejsnkdiz06sr4";
        private const string DropboxAppSecret = "rvime4wzbub66oz";

        public static void Main()
        {
            var client = new DropNetClient(DropboxAppKey, DropboxAppSecret);

            var token = client.GetToken();
            var url = client.BuildAuthorizeUrl();

            Console.WriteLine("Open browser with in : {0}", url);
            Console.WriteLine("Press enter when clicked allow");
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
              url);

            Console.ReadLine();
            var accessToken = client.GetAccessToken();

            client.UseSandbox = true;
            var metaDate = client.CreateFolder("Pictures " + DateTime.Now.ToString());

            string[] dir = Directory.GetFiles("../../Images/", "*.jpg");

            foreach (var item in dir)
            {
                Console.WriteLine("Uploading...");
                FileStream stream = File.Open(item, FileMode.Open);

                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);

                client.UploadFile("/" + metaDate.Name.ToString(), item.Substring(6), bytes);

                stream.Close();
            }

            var picUrl = client.GetShare(metaDate.Path);
            Console.WriteLine(picUrl.Url);
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
              picUrl.Url);
        }
    }
}
