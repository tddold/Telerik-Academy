using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.Cookies
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserName"];

            if (cookie != null)
            {
                this.LiteralLogin.Text = "Hello, " + cookie.Value;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}