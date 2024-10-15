using EmployeeNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComputeSalary_Click(object sender, EventArgs e)
        {
            EmployeeNamespace.PartTimeEmployee pte = new EmployeeNamespace.PartTimeEmployee
                (
                     firstnameTB.Text,
                     lastnameTB.Text,
                     departmentTB.Text,
                       JobTitleTB.Text
            );

            double ratePerHour = Convert.ToDouble(rateperhourTB.Text);
            int totalHourWorked = Convert.ToInt32(totalhoursworkedTB.Text);


            {
                pte.computeSalary(totalHourWorked, ratePerHour);
            }

            fnOUTPUT.Text = pte.firstName;
            lnOUTPUT.Text =  pte.lastName;

            bsOUTPUT.Text = Convert.ToString(pte.getSalary());
        }


    }
}
