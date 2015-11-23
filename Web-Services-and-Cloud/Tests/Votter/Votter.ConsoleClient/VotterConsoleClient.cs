namespace Votter.ConsoleClient
{
    using System;
    using Spring.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Votter.Data;
    using Votter.DropboxApi;
    using Votter.PubnubApi;

    public class VotterConsoleClient
    {
        private static readonly VotterData votterData = new VotterData();

        internal static void Main()
        {
            //Console.WriteLine(votterData.Pictures.All().Count());

            // Testing Dropbox
            var dropbox = new DropBoxCloudConnector();

            string testPicture = @"../../Resources/1.png";
            var file = new FileResource(testPicture);
            var uploadedGirl = dropbox.UploadGirlsToCloud(file);
            var uploadedBoy = dropbox.UploadBoysToCloud(file);

            var picGirlLink = dropbox.GetPictureLink("/Girls/1.png");
            var picBoyLink = dropbox.GetPictureLink("/Boys/1.png");
            Console.WriteLine(picGirlLink.Url);
            Console.WriteLine(picBoyLink.Url);

            // Testing Pubnub
            var pubnub = new PubnubAlert();
            pubnub.Start();
            while (true)
            {
                string msg = Console.ReadLine();

                pubnub.PublishMessage(msg);
            }
        }
    }
}