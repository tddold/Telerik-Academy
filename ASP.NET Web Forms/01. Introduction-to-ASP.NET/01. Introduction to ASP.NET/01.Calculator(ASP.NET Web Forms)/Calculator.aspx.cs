namespace _01.Calculator_ASP.NET_Web_Forms_
{
    using System;
    using System.Web.UI;

    public partial class Calculator : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.btnSum.Text = "Sum";
        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double.TryParse(this.btnFirstNumber.Text, out firstNumber);
            this.btnFirstNumber.Text = firstNumber.ToString();

            double secondNumber;
            double.TryParse(this.btnSecondNumber.Text, out secondNumber);
            this.btnSecondNumber.Text = secondNumber.ToString();


            this.btnResult.Text = (firstNumber + secondNumber).ToString();
        }
    }
}