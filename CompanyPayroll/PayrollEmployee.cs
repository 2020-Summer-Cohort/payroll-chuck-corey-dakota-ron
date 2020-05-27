using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    class PayrollEmployee
    {
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double paycheckTotal { get; set; }

       public string GetEmployeeName()
        {
            return lastName + ", " + firstName;
        }

    }
}
