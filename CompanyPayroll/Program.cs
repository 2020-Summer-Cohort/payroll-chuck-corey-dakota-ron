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
            //Prompt User
            double bonusAmount = PromptUserForBonusInfo();
            int hoursWorked = PromptUserForHoursInfo();
            //Console.WriteLine($"bouns = {bonusAmount}  hours={hoursWorked}");
            //Calc Pay
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
            //payrollEmployeeWorker = new PayrollEmployee();
            //payrollEmployeeWorker.lastName = "Whittle";
            //payrollEmployeeWorker.firstName = "Bennett";
            //payrollEmployeeWorker.employeeId = 102;
            //employees.Add(payrollEmployeeWorker);
            //payrollEmployeeWorker = new PayrollEmployee();
            //payrollEmployeeWorker.lastName = "jobs";
            //payrollEmployeeWorker.firstName = "Steve";
            //payrollEmployeeWorker.employeeId = 103;
            //employees.Add(payrollEmployeeWorker);
        }
        static void ListEmployees(List<PayrollEmployee> employees)
        {
            foreach (PayrollEmployee employee in employees)
            {
                Console.WriteLine(employee.employeeId + " " + employee.lastName + ", " + employee.firstName);
            }
        }
        static void ListEmployeesWithPay(List<PayrollEmployee> employees)
        {
            foreach (PayrollEmployee employee in employees)
            {
                Console.WriteLine(employee.employeeId + " " + employee.lastName + ", " + employee.firstName + " " + employee.paycheckTotal);
            }
        }

        static double PromptUserForBonusInfo()
        {
            Console.WriteLine("What was the bonus for this pay period?");
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
                    employee.paycheckTotal = salesEmployee.PayPeriodEarnings; // need to add bonus and commission
                }
            }
        }
        
        static void ReceivePayrollInfo(List<PayrollEmployee> employees)
        {
            foreach (PayrollEmployee employee in employees)
             {
                if (employee.GetType() == typeof(PayrollSales))
                {
                    PayrollSales salesEmployee = new PayrollSales();
                    salesEmployee = (PayrollSales)employee;
                    salesEmployee.ReceiveBonus(1);
                }
           
                Console.WriteLine($"enter bonus for {employee.employeeId}");
                string bonus = Console.ReadLine();
                
            }
        }

    }
}
