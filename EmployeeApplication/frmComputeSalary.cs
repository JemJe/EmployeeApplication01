using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInterface;

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
            PartTimeEmployee employee = new PartTimeEmployee(FirstNameBox.Text, LastNameBox.Text, DepartmentBox.Text, JobTitleBox.Text);

            if (employee == null)
            {
                return;
            }

            employee.ComputeSalary(Convert.ToInt32(TotalHoursWorkedBox.Text), Convert.ToDouble(RatePerHourBox.Text));

            firstnameLabel.Text = employee.FirstName;
            lastnameLabel.Text = employee.LastName;
            basicsalaryLabel.Text = employee.getSalary().ToString("0.00");
        }
    }
}
