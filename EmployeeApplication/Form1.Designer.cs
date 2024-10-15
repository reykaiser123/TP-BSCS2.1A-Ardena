namespace EmployeeApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstname = new Label();
            ComputeSalary = new Button();
            firstnameTB = new TextBox();
            lastnameTB = new TextBox();
            label2 = new Label();
            departmentTB = new TextBox();
            label3 = new Label();
            JobTitleTB = new TextBox();
            label4 = new Label();
            rateperhourTB = new TextBox();
            label5 = new Label();
            totalhoursworkedTB = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            fnOUTPUT = new Label();
            lnOUTPUT = new Label();
            bsOUTPUT = new Label();
            SuspendLayout();
            // 
            // firstname
            // 
            firstname.AutoSize = true;
            firstname.Location = new Point(12, 18);
            firstname.Name = "firstname";
            firstname.Size = new Size(80, 20);
            firstname.TabIndex = 0;
            firstname.Text = "First Name";
            // 
            // ComputeSalary
            // 
            ComputeSalary.Location = new Point(113, 237);
            ComputeSalary.Name = "ComputeSalary";
            ComputeSalary.Size = new Size(136, 29);
            ComputeSalary.TabIndex = 1;
            ComputeSalary.Text = "Compute Salary";
            ComputeSalary.UseVisualStyleBackColor = true;
            ComputeSalary.Click += ComputeSalary_Click;
            // 
            // firstnameTB
            // 
            firstnameTB.Location = new Point(12, 41);
            firstnameTB.Name = "firstnameTB";
            firstnameTB.Size = new Size(179, 27);
            firstnameTB.TabIndex = 2;
            // 
            // lastnameTB
            // 
            lastnameTB.Location = new Point(197, 41);
            lastnameTB.Name = "lastnameTB";
            lastnameTB.Size = new Size(170, 27);
            lastnameTB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 18);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // departmentTB
            // 
            departmentTB.Location = new Point(12, 102);
            departmentTB.Name = "departmentTB";
            departmentTB.Size = new Size(179, 27);
            departmentTB.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Department";
            // 
            // JobTitleTB
            // 
            JobTitleTB.Location = new Point(197, 102);
            JobTitleTB.Name = "JobTitleTB";
            JobTitleTB.Size = new Size(170, 27);
            JobTitleTB.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 79);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 7;
            label4.Text = "Job Title";
            // 
            // rateperhourTB
            // 
            rateperhourTB.Location = new Point(12, 204);
            rateperhourTB.Name = "rateperhourTB";
            rateperhourTB.Size = new Size(179, 27);
            rateperhourTB.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 9;
            label5.Text = "Rate Per Hour";
            // 
            // totalhoursworkedTB
            // 
            totalhoursworkedTB.Location = new Point(197, 204);
            totalhoursworkedTB.Name = "totalhoursworkedTB";
            totalhoursworkedTB.Size = new Size(170, 27);
            totalhoursworkedTB.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(197, 181);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 11;
            label6.Text = "Total hours worked";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 297);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 13;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 332);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 14;
            label8.Text = "Last Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 365);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 15;
            label9.Text = "Basic Salary";
            // 
            // fnOUTPUT
            // 
            fnOUTPUT.AutoSize = true;
            fnOUTPUT.Location = new Point(159, 297);
            fnOUTPUT.Name = "fnOUTPUT";
            fnOUTPUT.Size = new Size(58, 20);
            fnOUTPUT.TabIndex = 16;
            fnOUTPUT.Text = "label10";
            // 
            // lnOUTPUT
            // 
            lnOUTPUT.AutoSize = true;
            lnOUTPUT.Location = new Point(159, 332);
            lnOUTPUT.Name = "lnOUTPUT";
            lnOUTPUT.Size = new Size(58, 20);
            lnOUTPUT.TabIndex = 17;
            lnOUTPUT.Text = "label11";
            // 
            // bsOUTPUT
            // 
            bsOUTPUT.AutoSize = true;
            bsOUTPUT.Location = new Point(159, 365);
            bsOUTPUT.Name = "bsOUTPUT";
            bsOUTPUT.Size = new Size(58, 20);
            bsOUTPUT.TabIndex = 18;
            bsOUTPUT.Text = "label12";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bsOUTPUT);
            Controls.Add(lnOUTPUT);
            Controls.Add(fnOUTPUT);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(totalhoursworkedTB);
            Controls.Add(label6);
            Controls.Add(rateperhourTB);
            Controls.Add(label5);
            Controls.Add(JobTitleTB);
            Controls.Add(label4);
            Controls.Add(departmentTB);
            Controls.Add(label3);
            Controls.Add(lastnameTB);
            Controls.Add(label2);
            Controls.Add(firstnameTB);
            Controls.Add(ComputeSalary);
            Controls.Add(firstname);
            Name = "Form1";
            Text = "Employee Salary Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstname;
        private Button ComputeSalary;
        private TextBox firstnameTB;
        private TextBox lastnameTB;
        private Label label2;
        private TextBox departmentTB;
        private Label label3;
        private TextBox JobTitleTB;
        private Label label4;
        private TextBox rateperhourTB;
        private Label label5;
        private TextBox totalhoursworkedTB;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label fnOUTPUT;
        private Label lnOUTPUT;
        private Label bsOUTPUT;
    }
}
