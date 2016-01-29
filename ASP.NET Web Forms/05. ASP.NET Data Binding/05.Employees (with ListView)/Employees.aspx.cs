namespace EmployeesListView
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using EmployeesDataBinding;


    public partial class Employees : Page
    {
        private NorthwindEntities northwindContext = new NorthwindEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.LiveViewEmployees.DataSource = this.northwindContext.Employees.ToList();
                this.LiveViewEmployees.DataBind();
            }
        }

        private void Page_Upload(object sender, EventArgs e)
        {
            this.northwindContext.Dispose();
        }
    }
}