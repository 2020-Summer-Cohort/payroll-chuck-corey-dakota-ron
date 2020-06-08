using System;
using System.Collections.Generic;
using System.Globalization;

namespace CompanyPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Company Payroll App!");
            CompanyRoster companyRoster = new CompanyRoster();
            List<PayrollEmployee> payrollEmployeeWorkers = new List<PayrollEmployee>();
            companyRoster.PopulateEmployeeList(payrollEmployeeWorkers);
            ListEmployees(payrollEmployeeWorkers);
            double bonusAmount = PromptUserForBonusInfo();
            int hoursWorked = PromptUserForHoursInfo();
            ReceivePayrollInfo(payrollEmployeeWorkers,bonusAmount, hoursWorked);
            companyRoster.CalculatePay(payrollEmployeeWorkers);
            ListEmployeesWithPay(payrollEmployeeWorkers);
            
        }

        static void ListEmployees(List<PayrollEmployee> employees)
        {
            Console.WriteLine();
            foreach (PayrollEmployee employee in employees)
            {
                Console.WriteLine(employee.employeeId + " " + employee.lastName + ", " + employee.firstName);
            }
        }
        static void ListEmployeesWithPay(List<PayrollEmployee> employees)
        {
            Console.WriteLine();
            foreach (PayrollEmployee employee in employees)
            {
                Console.WriteLine(employee.employeeId + " " + employee.lastName + ", " + employee.firstName + " " + employee.paycheckTotal.ToString("C3",CultureInfo.CurrentCulture));
            }
        }

        static double PromptUserForBonusInfo()
        {
            Console.WriteLine("\nWhat was the bonus for this pay period?");
            double bonus = Convert.ToInt32(Console.ReadLine());
            return bonus;
        }

        static int PromptUserForHoursInfo()
        {
            Console.WriteLine("How many hours did the hourly employees work this pay period?");
            int hours = Convert.ToInt32(Console.ReadLine());
            return hours;
        }
        
        static void ReceivePayrollInfo(List<PayrollEmployee> employees, double bonus, int hoursWorked)
        {
            foreach (PayrollEmployee employee in employees)
             {
                if (employee is PayrollSales)
                {
                    PayrollSales salesEmployee;
                    salesEmployee = (PayrollSales)employee;
                    salesEmployee.SetSalesCommission(1000);
                    salesEmployee.ReceiveBonus(bonus);
                }
                else if (employee is PayrollHourly)
                {
                    PayrollHourly hourlyEmployee;
                    hourlyEmployee = (PayrollHourly)employee;
                    hourlyEmployee.SetHoursWorked(hoursWorked);
                }
                else if (employee is PayrollDeveloper)
                {
                    PayrollDeveloper developerEmployee;
                    developerEmployee = (PayrollDeveloper)employee;
                    developerEmployee.ReceiveBonus(bonus);
                    developerEmployee.PayInsurance(80);

                }
                else if (employee is PayrollExecutivese)
                {
                    PayrollExecutivese executiveseEmployee;
                    executiveseEmployee = (PayrollExecutivese)employee;
                    executiveseEmployee.ReceiveBonus(bonus);
                    executiveseEmployee.PayInsurance(10);
                }


            }
            }

    }
}
