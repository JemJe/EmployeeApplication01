using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApplication;

namespace EmployeeInterface 
{
    public class PartTimeEmployee : IEmployee
    {
        private string firstName;
        private string lastName;
        private string department;
        private string jobTitle;
        private double basicSalary;

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

        public string FirstName()
        {
            return firstName;
        }
        public string LastName()
        {
            return lastName;
        }
        public string Dpartment()
        {
            return department;
        }
        public string JobTitle()
        {
            return jobTitle;
        }
        public double BasicSalary()
        {
            return basicSalary;
        }
    }
}
