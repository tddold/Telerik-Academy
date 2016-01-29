using _01.EmployeesOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.EmployeesOrders
{
    public partial class _Default : Page
    {
        public IQueryable<EmployeeViewModel> SelectEmployees()
        {
            var db = new NorthwindEntities();
            var employees =
                db.Employees.Select(
                    e =>
                    new EmployeeViewModel
                    {
                        Address = e.Address,
                        EmployeeID = e.EmployeeID,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        Title = e.Title
                    }).OrderBy(e => e.EmployeeID);
            return employees;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var data = new NorthwindEntities();
                this.GridViewEmployees.DataSource = SelectEmployees().ToList();
                this.GridViewEmployees.DataBind();
            }
        }

        protected void GridViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateProgress.Attributes.CssStyle["display"] = "block";
            Thread.Sleep(5000);
            var gridView = sender as GridView;
            var employeeId = int.Parse(gridView.SelectedValue.ToString());
            this.RebindOrders(employeeId);
           
        }

        private void RebindOrders(int employeeId)
        {
            var db = new NorthwindEntities();
            this.GridViewOrders.DataSource = db.Orders.Where(x => x.EmployeeID == employeeId).ToList();
            this.GridViewOrders.DataBind();
            this.UpdateProgress.Attributes.CssStyle["display"] = "none";
        }
    }
}