using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    public class PayrollExecutivese : PayrollEmployee
    {
        public double Bonus { get; set; }
        public double PayPeriodEarnings { get; set; }
        public double Insurance { get; set; }

        public void ReceiveBonus(double bonus)
        {
            Bonus = bonus;
        }

        public void SetPayPeriordEarnings(double earnings)
        {
            PayPeriodEarnings = earnings;
        }

        public void PayInsurance(double insurance)
        {
            Insurance = insurance;
        }
    }
}
