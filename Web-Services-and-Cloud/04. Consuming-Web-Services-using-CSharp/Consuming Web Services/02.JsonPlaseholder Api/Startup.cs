namespace JsonPlaseholderApi
{
    class Startup
    {
        static void Main()
        {
            var httpClient = new GenericHttpClient();
            var forumData = new ForumData(httpClient);
            var forumClientApp = new ForumClientApp(forumData);

            forumClientApp.Start();
        }
    }
}
