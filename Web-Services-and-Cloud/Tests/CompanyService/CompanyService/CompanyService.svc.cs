namespace WcfCompanyService
{
    using System.Linq;
    using Company.Data;

    public class CompanyService : ICompanyService
    {
        public EmployeeInfo GetEmployeeInfo(int id)
        {
            var db = new TelerikAcademyEntities();
            var employeeInfo = db.Employees
                .Where(x => x.EmployeeID == id)
                .Select(x => new EmployeeInfo
                {
                    Id = x.EmployeeID,
                    Name = x.FirstName + " " + x.LastName,
                    Department = x.Departments1.Name
                })
                .FirstOrDefault();

            return employeeInfo;
        }

        public decimal GetEmployeeSalary(int id)
        {
            var db = new TelerikAcademyEntities();
            var employeeSalary = db.Employees
                .Where(x => x.EmployeeID == id)
                .Select(x => x.Salary)
                .FirstOrDefault();

            return employeeSalary;

        }

        public int GetEmployeesCount()
        {
            var db = new TelerikAcademyEntities();
            var count = db.Employees.Count();
            return count;
        }
    }
}
