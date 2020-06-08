using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyPayroll
{
    public class CompanyRoster
    {
        public void CalculatePay(List<PayrollEmployee> employees)
        {
            foreach (PayrollEmployee employee in employees)
            {
                if (employee is PayrollSales)
                {
                    PayrollSales salesEmployee;
                    salesEmployee = (PayrollSales)employee;
                    salesEmployee.SetPayPeriodEarnings(3000);
                    employee.paycheckTotal = salesEmployee.PayPeriodEarnings + salesEmployee.SalesCommission + salesEmployee.Bonus;
                }
                if (employee is PayrollHourly)
                {
                    PayrollHourly salesEmployee;
                    salesEmployee = (PayrollHourly)employee;
                    employee.paycheckTotal = salesEmployee.HoursWorked * 20.00;
                }
                else if (employee is PayrollDeveloper)
                {
                    PayrollDeveloper developerEmployee;
                    developerEmployee = (PayrollDeveloper)employee;
                    developerEmployee.SetPayPeriordEarnings(9000);
                    employee.paycheckTotal = developerEmployee.PayPeriodEarnings + developerEmployee.Bonus - developerEmployee.Insurance;

                }
                else if (employee is PayrollExecutivese)
                {
                    PayrollExecutivese executiveseEmployee;
                    executiveseEmployee = (PayrollExecutivese)employee;
                    executiveseEmployee.SetPayPeriordEarnings(20000);
                    employee.paycheckTotal = executiveseEmployee.PayPeriodEarnings + executiveseEmployee.Bonus - executiveseEmployee.Insurance;
                }

            }
        }
    }
}
