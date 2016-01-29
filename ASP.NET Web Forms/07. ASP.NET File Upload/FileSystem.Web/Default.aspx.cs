namespace FileSystem.Web
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using FileSystem.Data;
    public partial class _Default : Page
    {
        private readonly FileSystemDbContext data = new FileSystemDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.RepeaterContent.DataSource = this.data.FileContents.ToList();
            this.RepeaterContent.DataBind();
        }
    }
}