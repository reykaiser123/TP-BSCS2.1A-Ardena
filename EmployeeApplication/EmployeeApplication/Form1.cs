
using EmployeeApplication.IEmployee;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            PartTimeEmployee.PartTimeEMployee pte = new PartTimeEmployee.PartTimeEMployee
                (
                     firstnameTB.Text,
                     lastnameTB.Text,
                     departmentTB.Text,
                     jobtitleTB.Text
                );

            double ratePerHour = Convert.ToDouble(rphTB.Text);
            int totalHourWorked = Convert.ToInt32(thwTB.Text);


            {
                pte.computeSalary(totalHourWorked, ratePerHour);
            }

            fnOUTPUT.Text = firstnameTB.Text;
            lnOUTPUT.Text = lastnameTB.Text;

            bsOUTPUT.Text = Convert.ToString(pte.getSalary());
        }
    }

    namespace IEmployee
    {
        public interface IEmployees
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string department { get; set; }
            public string basicSalary { get; set; }


            public void computeSalary(int hoursWorked, double ratePerHour)
            {

            }

        }
    }

    namespace PartTimeEmployee
    {
        public class PartTimeEMployee : IEmployees
        {
            private string first_name;
            private string last_name;
            private string department;
            private string job_Title;
            private double balance_Salary;


            public PartTimeEMployee(string Fname, string Lname, string dept, string job)
            {
                this.first_name = Fname;
                this.last_name = Lname;
                this.department = dept;
                this.job_Title = job;
                return;
            }

            string IEmployees.firstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            string IEmployees.lastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            string IEmployees.department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            string IEmployees.basicSalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void computeSalary(int hoursWorked, double ratePerHour) { 
                this.balance_Salary = hoursWorked * ratePerHour;
            }

            public double getSalary()
            {
                return balance_Salary;
            }
        }
    }
}
