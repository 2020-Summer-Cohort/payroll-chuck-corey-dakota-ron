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

       public void PopulateEmployeeList(List<PayrollEmployee> employees)
        {
            PayrollSales payrollEmployeeWorker = new PayrollSales();
            payrollEmployeeWorker.lastName = "Givens";
            payrollEmployeeWorker.firstName = "Hannah";
            payrollEmployeeWorker.employeeId = 101;
            employees.Add(payrollEmployeeWorker);

            PayrollHourly payrollEmployeeHourly = new PayrollHourly();
            payrollEmployeeHourly.lastName = "Whittle";
            payrollEmployeeHourly.firstName = "Bennett";
            payrollEmployeeHourly.employeeId = 102;
            employees.Add(payrollEmployeeHourly);

            payrollEmployeeHourly = new PayrollHourly();
            payrollEmployeeHourly.lastName = "James";
            payrollEmployeeHourly.firstName = "LeBron";
            payrollEmployeeHourly.employeeId = 108;
            employees.Add(payrollEmployeeHourly);

            PayrollDeveloper payrollEmployeeDeveloper = new PayrollDeveloper();
            payrollEmployeeDeveloper.lastName = "Jobs";
            payrollEmployeeDeveloper.firstName = "Steve";
            payrollEmployeeDeveloper.employeeId = 103;
            employees.Add(payrollEmployeeDeveloper);

            payrollEmployeeDeveloper = new PayrollDeveloper();
            payrollEmployeeDeveloper.lastName = "Ballmer";
            payrollEmployeeDeveloper.firstName = "Steve";
            payrollEmployeeDeveloper.employeeId = 106;
            employees.Add(payrollEmployeeDeveloper);

            payrollEmployeeDeveloper = new PayrollDeveloper();
            payrollEmployeeDeveloper.lastName = "Wynn";
            payrollEmployeeDeveloper.firstName = "Steve";
            payrollEmployeeDeveloper.employeeId = 107;
            employees.Add(payrollEmployeeDeveloper);

            PayrollExecutivese payrollEmployeeExecutivese = new PayrollExecutivese();
            payrollEmployeeExecutivese.lastName = "Musk";
            payrollEmployeeExecutivese.firstName = "Elon";
            payrollEmployeeExecutivese.employeeId = 104;
            employees.Add(payrollEmployeeExecutivese);
        }
    }


}
