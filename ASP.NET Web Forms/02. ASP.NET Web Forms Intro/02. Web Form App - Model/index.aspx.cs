namespace _02.Web_Form_App___Model
{
    using System;
    using System.Reflection;
    using System.Web.UI;

    public partial class index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblWebForm.Text = "Hello, ASP.NET";
            this.lblLocationTextBlock.Text = "Location: " + Assembly.GetExecutingAssembly().Location;
        }
    }
}