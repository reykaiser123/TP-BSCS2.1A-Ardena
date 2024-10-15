using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInterface
{
    internal interface IEmployee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string department { get; set; }
        public double basicSalary { get; set; }


        public void computeSalary(int hoursWorked, double ratePerHour);

        
    }

}
