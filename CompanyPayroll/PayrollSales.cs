using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace CompanyPayroll
{
    public class PayrollSales:PayrollEmployee
    {
        public double SalesCommission { get; set; }
        public double PayPeriodEarnings { get; set; }
        public double Bonus { get; set; }
        public void ReceiveBonus(double bonus)
        {
            Bonus = bonus;     
        }
        public void SetSalesCommission(double salesCommissionAmount)
        {
            SalesCommission = salesCommissionAmount;
        }

        public void SetPayPeriodEarnings (double earnings)
        {
            PayPeriodEarnings = earnings;
        }
        
    }
    
}
