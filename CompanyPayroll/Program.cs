using System;

namespace CompanyPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PayrollEmployee payrollEmployeeWorker = new PayrollEmployee();
            payrollEmployeeWorker.lastName = "Givens";
            payrollEmployeeWorker.firstName = "Hannah";
            Console.WriteLine(payrollEmployeeWorker.GetEmployeeName());
                
        }
    }
}
