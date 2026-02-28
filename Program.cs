
using System;
namespace Payslip
{

    class Program
    {

        static void Main(string[] args)
        {


            string employeeName;
            string employeeNumber;
            double basicSalary;
            double allowances;
            double overTime;
            int leaveDays;
            int daysPresent;
            string shift;
            double sss, philHealth, pagIbig;

            Console.WriteLine("===MONTHLY EMPLOYEE PAYSLIP SYSTEM===");

            Console.WriteLine("Enter name of the Employee: ");
            employeeName = Console.ReadLine();


            Console.WriteLine("Enter Employee Number: ");
            employeeNumber = Console.ReadLine();

            Console.WriteLine("Basic Salary: ");
            basicSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Allowances: ");
            allowances = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Regular Overtime: ");
            overTime = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Number of Days Leaves: ");
            leaveDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of Days Present: ");
            daysPresent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Shift Duration: ");
            shift = Console.ReadLine();

            Console.WriteLine("SSS Deduction: ");
            sss = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Philhealth Deduction: ");
            philHealth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("PagIbig Deduction: ");
            pagIbig = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("---------------------------------------- ");
            Console.WriteLine("EMPLOYEE " + employeeNumber + " DATA");
            Console.WriteLine("---------------------------------------- ");
            Console.WriteLine("Employee Name: " + employeeName);
            Console.WriteLine("Employee Number: " + employeeNumber);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Allowances: " + allowances);
            Console.WriteLine("Total of Leaves: " + leaveDays);
            Console.WriteLine("Number of Days Present: " + daysPresent);
            Console.WriteLine("Duration of Shift: " + shift);
            Console.WriteLine("SSS Deduction: " + sss);
            Console.WriteLine("PhilHealth Deduction: " + philHealth);
            Console.WriteLine("PagIbig Deduction: " + pagIbig);


            

            double grossSalary = basicSalary + allowances + overTime;
            double taxableIncome = grossSalary - sss - philHealth - pagIbig;



            if (taxableIncome < 20833)
            {
                double incomeTax1 = 0.0;
                double netSalary1 = grossSalary - sss - philHealth - pagIbig - incomeTax1;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Net Salary: " + netSalary1);
            }
            else if (taxableIncome > 20833 && (taxableIncome <= 33333))
            {
                double incomeTax2 = ((taxableIncome - 20833) * 0.15);
                double netSalary2 = grossSalary - sss - philHealth - pagIbig - incomeTax2;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Net Salary: " + netSalary2);
            }
            else if (taxableIncome > 33333 && (taxableIncome <= 66667))
            {
                double incomeTax3 = ((taxableIncome - 20833) * 0.20);
                double netSalary3 = grossSalary - sss - philHealth - pagIbig - incomeTax3;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Net Salary: " + netSalary3);

            }
            else if (taxableIncome > 66667 && (taxableIncome <= 166667))
            {
                double incomeTax4 = ((taxableIncome - 20833) * 0.25);
                double netSalary4 = grossSalary - sss - philHealth - pagIbig - incomeTax4;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Net Salary: " + netSalary4);
            }
            else if (taxableIncome > 166667 && (taxableIncome <= 666667))
            {
                double incomeTax5 = ((taxableIncome - 20833) * 0.30);
                double netSalary5 = grossSalary - sss - philHealth - pagIbig - incomeTax5;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Net Salary: " + netSalary5);

            }
            else
            {
                //income tax > 666667
                double incomeTax6 = ((taxableIncome - 20833) * 0.35);
                double netSalary6 = grossSalary - sss - philHealth - pagIbig - incomeTax6;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Net Salary: " + netSalary6);

            }

        }
    }
}
