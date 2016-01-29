namespace EmployeesDataBinding
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;


    public partial class EmployeeDetails : Page
    {
        private NorthwindEntities northwindContext = new NorthwindEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int empliyeeId;
            if (!int.TryParse(this.Request.Params["id"], out empliyeeId))
            {
                this.RedirectToHomePage();
            }

            var employee = this.northwindContext.Employees.Find(empliyeeId);
            if (employee == null)
            {
                this.RedirectToHomePage();
            }


            this.EmployeeDetailsView.DataSource = new List<Employees>() { employee };
            this.EmployeeDetailsView.DataBind();
        }

        protected void OnBackButtonClick(object sender, EventArgs e)
        {
            this.RedirectToHomePage();
        }

        private void RedirectToHomePage()
        {
            this.Response.Redirect("Employees.aspx");
        }
    }
}