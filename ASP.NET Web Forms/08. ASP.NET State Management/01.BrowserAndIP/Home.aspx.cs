using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.BrowserAndIP
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LabelBrowser.Text = this.Request.Browser.Browser;
            this.LabelIPAddress.Text = HttpContext.Current.Request.UserHostAddress;

        }
    }
}