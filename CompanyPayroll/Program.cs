using System;
using System.Collections.Generic;

namespace CompanyPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(payrollEmployeeWorker.GetEmployeeName());
            List<PayrollEmployee> payrollEmployeeWorkers = new List<PayrollEmployee>();
            PopulateEmployeeList(payrollEmployeeWorkers);
            ListEmployees(payrollEmployeeWorkers);
            ListEmployeesWithPay(payrollEmployeeWorkers);
            //bool whilePlaying = true;
            //while (whilePlaying)
            //{
            //    ShowMenu();
            //    Console.WriteLine("Please choose a menu option");
            //    string userInput = Console.ReadLine();
            //    switch (userInput)
            //    {
            //        case "1":
            //            ListEmployees(payrollEmployeeWorkers);
            //            break;
            //        case "2":
            //            break;
            //        case "3":
            //            break;
            //        case "4":
            //            whilePlaying = false;
            //            break;
            //        default:
            //            Console.WriteLine("Please choose a valid option");
            //            break;
            //    }
            //}
            
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
        static void ShowMenu()
        {
            Console.WriteLine("1. List employees in company roster");
            Console.WriteLine("2. Prompt for information on current pay period");
            Console.WriteLine("3. Output list of employees with paycheck");
            Console.WriteLine("4. Quit");
        }
        static void ListEmployeesWithPay(List<PayrollEmployee> employees)
        {
            foreach (PayrollEmployee employee in employees)
            {
                Console.WriteLine(employee.employeeId + " " + employee.lastName + ", " + employee.firstName + " " + employee.paycheckTotal);
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
