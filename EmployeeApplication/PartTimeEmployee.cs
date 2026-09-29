using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeInterface 
{
    public class PartTimeEmployee : IEmployee
    {
        private string firstName;
        private string lastName;
        private string department;
        private string jobTitle;
        private double basicSalary;


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }

        public PartTimeEmployee(string firstName, string lastName, string department, string jobTitle)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
            this.jobTitle = jobTitle;
        }

        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            basicSalary = hoursWorked * ratePerHour;
        }

        public double getSalary()
        {
            return basicSalary;
        }
    }
}
