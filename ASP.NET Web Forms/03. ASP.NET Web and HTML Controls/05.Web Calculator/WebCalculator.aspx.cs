namespace _05.Web_Calculator
{
    using System;
    using System.Linq;
    using System.Globalization;
    using System.Web.UI;

    public partial class WebCalculator : Page
    {
        CultureInfo provider = new CultureInfo("en-GB");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.tbNumber.Text = this.tbNumber.Text + "1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.tbNumber.Text = this.tbNumber.Text + "2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            this.tbNumber.Text = this.tbNumber.Text + "3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            this.tbNumber.Text = this.tbNumber.Text + "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            this.tbNumber.Text = this.tbNumber.Text + "5";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            this.tbNumber.Text = this.tbNumber.Text + "6";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            this.tbNumber.Text = this.tbNumber.Text + "7";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            this.tbNumber.Text = this.tbNumber.Text + "8";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            this.tbNumber.Text = this.tbNumber.Text + "9";
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            this.tbNumber.Text = this.tbNumber.Text + "0";
        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (this.tbNumber.Text == "")
            {
                return;
            }
            else
            {
                this.lastOperand.Value = "+";
                this.firstValue.Value = this.tbNumber.Text;
                this.tbNumber.Text = "";
            }
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (this.tbNumber.Text == "")
            {
                return;
            }
            else
            {
                this.lastOperand.Value = "-";
                this.firstValue.Value = this.tbNumber.Text;
                this.tbNumber.Text = "";
            }
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (this.tbNumber.Text == "")
            {
                return;
            }
            else
            {
                this.lastOperand.Value = "*";
                this.firstValue.Value = this.tbNumber.Text;
                this.tbNumber.Text = "";
            }
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (this.tbNumber.Text == "")
            {
                return;
            }
            else
            {
                this.lastOperand.Value = "/";
                this.firstValue.Value = this.tbNumber.Text;
                this.tbNumber.Text = "";
            }
        }

        protected void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            if (this.tbNumber.Text == "")
            {
                return;
            }
            else
            {
                this.tbNumber.Text = Math.Sqrt(double.Parse(this.tbNumber.Text, provider)).ToString();
            }
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            this.tbNumber.Text = "";
        }

        protected void ButtonEqual_Click(object sender, EventArgs e)
        {

            switch (this.lastOperand.Value)
            {

                case "+":
                    this.tbNumber.Text = (decimal.Parse(this.firstValue.Value, provider) + decimal.Parse(this.tbNumber.Text, provider)).ToString();

                    this.firstValue.Value = string.Empty;
                    this.lastOperand.Value = string.Empty;
                    break;
                case "-":
                    this.tbNumber.Text = (decimal.Parse(this.firstValue.Value, provider) - decimal.Parse(this.tbNumber.Text, provider)).ToString();

                    this.firstValue.Value = string.Empty;
                    this.lastOperand.Value = string.Empty;
                    break;
                case "*":
                    this.tbNumber.Text = (decimal.Parse(this.firstValue.Value, provider) * decimal.Parse(this.tbNumber.Text, provider)).ToString();

                    this.firstValue.Value = string.Empty;
                    this.lastOperand.Value = string.Empty;
                    break;
                case "/":
                    try
                    {
                        this.tbNumber.Text = (decimal.Parse(this.firstValue.Value, provider) / decimal.Parse(this.tbNumber.Text, provider)).ToString();

                        this.firstValue.Value = string.Empty;
                        this.lastOperand.Value = string.Empty;
                    }
                    catch (Exception)
                    {

                        this.tbNumber.Text = "cannot divide by zero";
                    }

                    break;
                default:
                    this.firstValue.Value = string.Empty;
                    this.lastOperand.Value = string.Empty;
                    break;
            }
        }
    }
}