using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    public class PayrollEmployee
    {
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double paycheckTotal { get; set; }

       public string GetEmployeeName()
        {
            return lastName + ", " + firstName;
        }
        public double GetPaycheckTotal()
        {
            return paycheckTotal;
        }
        public int GetEmployeeId()
        {
            return employeeId;
        }
    }
}
