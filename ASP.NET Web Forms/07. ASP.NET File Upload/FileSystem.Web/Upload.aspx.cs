namespace FileSystem.Web
{
    using System;
    using System.IO;
    using System.Web.UI;
    using Ionic.Zip;
    using FileSystem.Data;
    using FileSystem.Models;

    public partial class Upload : Page
    {
        private readonly FileSystemDbContext data = new FileSystemDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Expires = -1;

            try
            {
                var fileStream = this.Request.Files["uploaded"].InputStream;

                using (var archive = ZipFile.Read(fileStream))
                {
                    foreach (var entry in archive.Entries)
                    {
                        var memoryStream = new MemoryStream();
                        var streamReader = new StreamReader(memoryStream);

                        entry.Extract(memoryStream);
                        memoryStream.Seek(0, SeekOrigin.Begin);

                        var zipFileContent = streamReader.ReadToEnd();

                        this.data.FileContents.Add(new FileContent { Content = zipFileContent });

                        this.data.SaveChanges();
                    }
                }

                this.Response.ContentType = "application/json";
                this.Response.Write("{}");
            }
            catch (Exception ex)
            {
                this.Response.Write(ex.Message);
            }
        }
    }
}
