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
            Console.WriteLine(payrollEmployeeWorkers[1].lastName); 
        }
        static void PopulateEmployeeList(List<PayrollEmployee> employees)
        {
            PayrollEmployee payrollEmployeeWorker = new PayrollEmployee();
            payrollEmployeeWorker.lastName = "Givens";
            payrollEmployeeWorker.firstName = "Hannah";
            payrollEmployeeWorker.employeeId = 001;
            employees.Add(payrollEmployeeWorker);
            payrollEmployeeWorker = new PayrollEmployee();
            payrollEmployeeWorker.lastName = "Bennett";
            payrollEmployeeWorker.firstName = "Whittle";
            payrollEmployeeWorker.employeeId = 002;
            employees.Add(payrollEmployeeWorker);
            payrollEmployeeWorker = new PayrollEmployee();
            payrollEmployeeWorker.lastName = "Steve";
            payrollEmployeeWorker.firstName = "Jobs";
            payrollEmployeeWorker.employeeId = 003;
            employees.Add(payrollEmployeeWorker);
        }
    }
}
