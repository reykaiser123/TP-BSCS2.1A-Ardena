using EmployeeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    internal class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_Title;
        private double basic_Salary;


        public PartTimeEmployee(string Fname, string Lname, string dept, string job)
        {
            this.first_name = Fname;
            this.last_name = Lname;
            this.department = dept;
            this.job_Title = job;
            return;

        }

        public string firstName { get { return first_name; } set { first_name = value;} }
        public string lastName { get { return last_name; } set { last_name = value; } }
        public double basicSalary { get { return basic_Salary; } set { basic_Salary = value; } }
        string IEmployee.department { get { return department; } set { department = value; } }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            this.basic_Salary = hoursWorked * ratePerHour;
        }

        public double getSalary()
        {
            return basic_Salary;
        }
    }
}
