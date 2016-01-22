namespace _02.HTML_escaping
{
    using System;
    using System.Web.UI;

    public partial class Escaping : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnButtonSubmit_Click(object sender, EventArgs e)
        {
            var enteredText = this.tbInputTextBox.Text;

            this.tbEnteredTextBox.Text = this.Server.HtmlEncode(enteredText);
            this.lblEnteredTexLabel.Text = this.Server.HtmlEncode(enteredText);
        }
    }
}