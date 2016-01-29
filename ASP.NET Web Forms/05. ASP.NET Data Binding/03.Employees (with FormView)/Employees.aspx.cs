namespace EmployeesFormView
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

            var id = Request.QueryString["id"];
            if (id != null)
            {
                this.FormViewEmployees.ChangeMode(FormViewMode.Edit);
                this.FormViewEmployees.PageIndex = int.Parse(id) - 1;
                this.FormViewEmployees.AllowPaging = false;
            }

            this.FormViewEmployees.DataSource = this.northwindContext.Employees.ToList();
            this.DataBind();
        }

        protected void Page_Upload(object sender, EventArgs e)
        {
            this.northwindContext.Dispose();
        }

        protected void FormViewEmployees_PageIndexChanged(object sender, FormViewPageEventArgs e)
        {
            this.FormViewEmployees.PageIndex = e.NewPageIndex;
            this.FormViewEmployees.DataSource = this.northwindContext.Employees.ToList();
            this.FormViewEmployees.DataBind();
        }

        protected void OnBackButtonClick(object sender, EventArgs e)
        {
            this.Response.Redirect("Employees.aspx");
        }
    }
}