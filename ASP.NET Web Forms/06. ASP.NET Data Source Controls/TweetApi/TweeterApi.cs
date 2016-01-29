namespace TweetApi
{
    using Newtonsoft.Json;
    using System;
    using System.Data;
    using System.IO;
    using Microsoft.SqlServer;
    using System.Web;
    public class TweeterApi
    {
        public DataTable GetAllFiles()
        {
            DataTable dt = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath("tweets.json")))
                {
                    string line = sr.ReadToEnd();
                    // dt = JsonConvert.DeserializeObject<dynamic>(line);
                    dt = (DataTable)JsonConvert.DeserializeObject(line, (typeof(DataTable)));
                }
            }
            catch (Exception ex)
            {
                throw new FormatException("Error" + ex);
            }

            return dt;
        }

    }
}