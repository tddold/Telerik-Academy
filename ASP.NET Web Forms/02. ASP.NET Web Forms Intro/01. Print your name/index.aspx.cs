using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.Print_your_name
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.btnSubit.Text = "Submit";
        }

        protected void OnButtonClicked(object sender, EventArgs e)
        {
            this.lblNameResultBox.Text = String.Format("Your name is: {0}", this.btnNameTextBox.Text);
        }
    }
}