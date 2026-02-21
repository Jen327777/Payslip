
using System;
namespace Payslip
{
    class Employee
    {

        public string employeeName;
        public string employeeNumber;
        public double basicSalary;
        public double allowances;
        public int leaveDays;
        public int daysPresent;
        public string shift;
        


    }

    class Program
    {
      
        static void Main(string[] args)
        {


            Employee emp = new Employee();

            Console.WriteLine("===MONTHLY EMPLOYEE PAYSLIP SYSTEM===");

             Console.WriteLine("Enter name of the Employee: ");
             emp.employeeName = Console.ReadLine();


            Console.WriteLine("Enter Employee Number: ");
            emp.employeeNumber = Console.ReadLine();

            Console.WriteLine("Basic Salary: ");
            emp.basicSalary=  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Allowances: ");
            emp.allowances = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Number of Days Leaves: ");
            emp.leaveDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of Days Present: ");
            emp.daysPresent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Shift Duration: ");
            emp.shift = Console.ReadLine();





            Console.WriteLine("---------------------------------------- ");
            Console.WriteLine("EMPLOYEE " +emp.employeeNumber + " DATA");
            Console.WriteLine("---------------------------------------- ");
            Console.WriteLine("Employee Name: " + emp.employeeName);
            Console.WriteLine("Employee Number: " +emp.employeeNumber);
            Console.WriteLine("Basic Salary: " + emp.basicSalary);
            Console.WriteLine("Allowances: " + emp.allowances);
            Console.WriteLine("Total of Leaves " + emp.leaveDays);
            Console.WriteLine("Number of Days Present: " + emp.daysPresent);
            Console.WriteLine("Duration of Shift: " + emp.shift);
        }
    }
}
