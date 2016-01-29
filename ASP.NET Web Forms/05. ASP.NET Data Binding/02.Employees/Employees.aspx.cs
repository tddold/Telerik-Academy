namespace EmployeesDataBinding
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;


    public partial class Employees : Page
    {
        private NorthwindEntities northwindContext = new NorthwindEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.GirdViewEmployees.DataSource = this.northwindContext.Employees
                    .Select(x => new
                    {
                        EmployeeID = x.EmployeeID,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        HomePhone = x.HomePhone
                    })
                    .ToList();

                this.GirdViewEmployees.DataBind();
            }
        }
    }
}