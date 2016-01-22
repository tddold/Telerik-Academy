using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.Random_Number
{
    public partial class RandomNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.buttonSubmit.Text = "Submit";
        }

        protected void btnSubmit_ServerClick(object sender, EventArgs e)
        {
            int minNumber;
            int.TryParse(this.minNumberInput.Value, out minNumber);


            int maxNumber;
            int.TryParse(this.maxNumberInput.Value, out maxNumber);
            var randomNumber = new Random();

            this.result.Value = randomNumber.Next(minNumber, maxNumber +1).ToString();
        }

        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            int minNumber;
            int.TryParse(this.tbMin.Text, out minNumber);


            int maxNumber;
            int.TryParse(this.tbMax.Text, out maxNumber);
            var randomNumber = new Random();

            this.lblResult.Text = randomNumber.Next(minNumber, maxNumber + 1).ToString();
        }
    }
}