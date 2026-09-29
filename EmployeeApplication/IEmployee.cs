using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInterface
{
    public interface IEmployee
    {
        string FirstName();
        string LastName();
        string Dpartment();
        string JobTitle();
        double BasicSalary();

        void ComputeSalary(int hoursWorked, double ratePerHour);
    }
}

