namespace Votter.DropboxApi
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using Spring.IO;
    using Spring.Social.Dropbox.Api;
    using Spring.Social.Dropbox.Connect;
    using Spring.Social.OAuth1;

    public class DropBoxCloud
    {
        private const string DropboxAppKey = "u5gmyjpg19cg66v";
        private const string DropboxAppSecret = "3ry0ttv14dh4l9d";
        private const string OAuthTokenFileName = "../../../Votter.DropboxApi/Resources/OAuthTokenFileName.txt";

        private string dropboxAppKey;
        private string dropboxAppSecret;
        private IDropbox dropboxApi;
        private OAuthToken oauthAccessToken;

        public DropBoxCloud()
            : this(DropboxAppKey, DropboxAppSecret)
        {
        }

        public DropBoxCloud(string key, string secret)
        {
            this.dropboxAppKey = key;
            this.dropboxAppSecret = secret;
            this.dropboxApi = this.GetDropboxApi();
        }

        public Entry UploadToCloud(FileResource resource, string folder)
        {
            Console.WriteLine(resource);
            Console.WriteLine(folder);
            Entry uploadFileEntry = this.dropboxApi.UploadFileAsync(resource, folder).Result;

            return uploadFileEntry;
        }

        public DropboxLink GetMediaLink(string path)
        {
            var mediaLink = this.dropboxApi.GetMediaLinkAsync(path).Result;

            return mediaLink;
        }

        public Entry GetAllMediaFiles(string path)
        {
            var mediaLink = this.dropboxApi.GetMetadataAsync(path).Result;

            return mediaLink;
        }

        private IDropbox GetDropboxApi()
        {
            DropboxServiceProvider serviceProvider = this.Initialize(this.dropboxAppKey, this.dropboxAppSecret);
            IDropbox currentDropboxApi = serviceProvider.GetApi(this.oauthAccessToken.Value, this.oauthAccessToken.Secret);

            return currentDropboxApi;
        }

        private DropboxServiceProvider Initialize(string key, string secret)
        {
            DropboxServiceProvider dropboxServiceProvider = new DropboxServiceProvider(key, secret, AccessLevel.Full);

            if (!File.Exists(OAuthTokenFileName))
            {
                this.AuthorizeAppOAuth(dropboxServiceProvider);
            }

            this.oauthAccessToken = this.LoadOAuthToken();

            return dropboxServiceProvider;
        }

        private void AuthorizeAppOAuth(DropboxServiceProvider dropboxServiceProvider)
        {
            OAuthToken oauthToken = dropboxServiceProvider.OAuthOperations.FetchRequestTokenAsync(null, null).Result;

            OAuth1Parameters parameters = new OAuth1Parameters();
            string authenticateUrl = dropboxServiceProvider.OAuthOperations.BuildAuthorizeUrl(oauthToken.Value, parameters);
            Process.Start(authenticateUrl);
            Console.Write("Press [Enter] when authorization attempt has succeeded.");
            Console.ReadLine();

            AuthorizedRequestToken requestToken = new AuthorizedRequestToken(oauthToken, null);
            OAuthToken oauthAccessToken =
                dropboxServiceProvider.OAuthOperations.ExchangeForAccessTokenAsync(requestToken, null).Result;

            string[] oauthData = new string[] { oauthAccessToken.Value, oauthAccessToken.Secret };
            File.WriteAllLines(OAuthTokenFileName, oauthData);
        }

        private OAuthToken LoadOAuthToken()
        {
            string[] lines = File.ReadAllLines(OAuthTokenFileName);
            this.oauthAccessToken = new OAuthToken(lines[0], lines[1]);

            return this.oauthAccessToken;
        }
    }
}