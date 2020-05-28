using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    public class PayrollSales:PayrollEmployee
    {
        public double SalesComission { get; set; }
        public double PayPeriodEarnings { get; set; }
        public void RecieveBonus()
        {

        }
        public void SetSalesComission(double salesComissionAmount)
        {
            SalesComission = salesComissionAmount;
        }
    }
    
}
