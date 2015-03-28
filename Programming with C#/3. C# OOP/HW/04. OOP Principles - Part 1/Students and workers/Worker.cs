namespace Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;
        private decimal moneyPerHour;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MoneyPerHour();
        }

        public int WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }

            set { this.workHoursPerDay = value; }
        }

        public decimal MoneyPerHour()
        {
            this.moneyPerHour = ((decimal)this.weekSalary / 5.0M) / (decimal)this.workHoursPerDay;
            return this.moneyPerHour;
        }
    }
}
