using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LasttName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public int WeekSalary { get; private set; }
        public int WorkHoursPerDay { get; private set; }
        public override string FirstName { get; set; }
        public override string LasttName { get; set; }
        public int MoneyPerHour()
        {
            return WeekSalary / WorkHoursPerDay;
        }

    }
}
