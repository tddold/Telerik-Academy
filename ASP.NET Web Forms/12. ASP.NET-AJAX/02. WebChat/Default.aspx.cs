using _02.WebChat.Models;
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.WebChat
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            var db = new WebChatDbContext();
            this.ListViewMessages.DataSource = db.Messages.Take(100).ToList();
            this.ListViewMessages.DataBind();

            if (this.User.Identity.IsAuthenticated)
            {
                // this.ButtonSend.Visible = false;
            }
        }

        protected void ButtonSend_OnClick(object sender, EventArgs e)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Account/Register.aspx");
                Response.End();
            }

            var username = this.User.Identity.Name;
            var text = this.TextBoxContent.Text;

            var message = new Message { Content = text, Username = username, DatePublished = DateTime.Now };

            var data = new WebChatDbContext();

            data.Messages.Add(message);
            data.SaveChanges();

            this.TextBoxContent.Text = string.Empty;
        }
    }
}