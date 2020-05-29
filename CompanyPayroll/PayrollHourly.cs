using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    public class PayrollHourly : PayrollEmployee
    {
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set;}

        public void SetHoursWorked (int hoursWorked)
        {
            HoursWorked = hoursWorked;
        }
    }
}
