namespace Votter.DropboxApi
{
    using System;
    using System.Linq;
    using Spring.IO;
    using Spring.Social.Dropbox.Api;

    public class DropBoxCloudConnector
    {
        private const string GirlsCollection = "Girls";
        private const string BoysCollection = "Boys";

        private readonly DropBoxCloud dropBoxCloud;

        public DropBoxCloudConnector()
            : this(new DropBoxCloud())
        {
        }

        public DropBoxCloudConnector(DropBoxCloud dropBoxCloud)
        {
            this.dropBoxCloud = dropBoxCloud;
        }

        public Entry UploadGirlsToCloud(FileResource resource)
        {
            string collection = "/" + GirlsCollection + "/" + resource.File.Name;
            var entry = this.dropBoxCloud.UploadToCloud(resource, collection);
            return entry;
        }

        public Entry UploadBoysToCloud(FileResource resource)
        {
            string collection = "/" + BoysCollection + "/" + resource.File.Name;
            var entry = this.dropBoxCloud.UploadToCloud(resource, collection);
            return entry;
        }

        public Entry GetAllPicturesGirls()
        {
            var girlPctures = this.dropBoxCloud.GetAllMediaFiles(GirlsCollection);

            return girlPctures;
        }

        public Entry GetAllPicturesBoys()
        {
            var boyPctures = this.dropBoxCloud.GetAllMediaFiles(GirlsCollection);

            return boyPctures;
        }

        public DropboxLink GetPictureLink(string path)
        {
            var pictureLink = this.dropBoxCloud.GetMediaLink(path);

            return pictureLink;
        }
    }
}