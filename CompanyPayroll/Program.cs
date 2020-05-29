using System;
using System.Collections.Generic;

namespace CompanyPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Company Payroll App!");
            List<PayrollEmployee> payrollEmployeeWorkers = new List<PayrollEmployee>();
            PopulateEmployeeList(payrollEmployeeWorkers);
            ListEmployees(payrollEmployeeWorkers);
            double bonusAmount = PromptUserForBonusInfo();
            int hoursWorked = PromptUserForHoursInfo();
            ReceivePayrollInfo(payrollEmployeeWorkers,bonusAmount, hoursWorked);
            CalculatePay(payrollEmployeeWorkers);
            ListEmployeesWithPay(payrollEmployeeWorkers);
            
        }

        static void PopulateEmployeeList(List<PayrollEmployee> employees)
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

            PayrollDeveloper payrollEmployeeDeveloper = new PayrollDeveloper();
            payrollEmployeeDeveloper.lastName = "Jobs";
            payrollEmployeeDeveloper.firstName = "Steve";
            payrollEmployeeDeveloper.employeeId = 103;
            employees.Add(payrollEmployeeDeveloper);
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
                Console.WriteLine(employee.employeeId + " " + employee.lastName + ", " + employee.firstName + " " + employee.paycheckTotal);
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

        static void CalculatePay(List<PayrollEmployee> employees)
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
                    employee.paycheckTotal = developerEmployee.PayPeriodEarnings + developerEmployee.Bonus + developerEmployee.Insurance;

                }

            }
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


            }
            }

    }
}
