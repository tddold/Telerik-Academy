using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationControls
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                this.LabelMessage.Text = "The page is valid!";
            }

            this.LabelMessage.Visible = this.IsValid;
        }
    }
}