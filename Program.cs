
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
            int holidayDays;
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

            Console.WriteLine("Number of Holiday Days: ");
            holidayDays = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("\nEMPLOYEE " + employeeNumber + " DATA\n");
            Console.WriteLine("---------------------------------------- ");
            Console.WriteLine("Employee Name: " + employeeName);
            Console.WriteLine("Employee Number: " + employeeNumber);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Allowances: " + allowances);
            Console.WriteLine("Overtime: " + overTime);
            Console.WriteLine("Holidays: " + holidayDays + "Present Holiday.");
            Console.WriteLine("Total of Leaves: " + leaveDays);
            Console.WriteLine("Number of Days Present: " + daysPresent);
            Console.WriteLine("Duration of Shift: " + shift);
            Console.WriteLine("SSS Deduction: " + sss);
            Console.WriteLine("PhilHealth Deduction: " + philHealth);
            Console.WriteLine("PagIbig Deduction: " + pagIbig);
            Console.WriteLine("   ");
            Console.WriteLine("   ");



            double dailyRate = basicSalary / 22;
            double holidayPay = dailyRate * holidayDays;
            double grossSalary = (dailyRate * daysPresent) + holidayPay + allowances + overTime;
            double taxableIncome = grossSalary - sss - philHealth - pagIbig;



            if (taxableIncome < 20833)
            {
                double incomeTax1 = 0.0;
                double netSalary1 = taxableIncome  - incomeTax1;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Gross Pay: " + grossSalary);
                Console.WriteLine("Total Deductions: " + (sss + philHealth + pagIbig));
                Console.WriteLine("Income Tax: " + incomeTax1);
                Console.WriteLine("Net Salary: " + netSalary1);
            }
            else if (taxableIncome > 20833 && (taxableIncome <= 33333))
            {
                double incomeTax2 = ((taxableIncome - 20833) * 0.15);
                double netSalary2 = taxableIncome - incomeTax2;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Gross Pay: " + grossSalary);
                Console.WriteLine("Total Deductions: " + (sss + philHealth + pagIbig));
                Console.WriteLine("Income Tax: " + incomeTax2);
                Console.WriteLine("Net Salary: " + netSalary2);
            }
            else if (taxableIncome > 33333 && (taxableIncome <= 66667))
            {
                double incomeTax3 = ((taxableIncome - 20833) * 0.20);
                double netSalary3 = taxableIncome  - incomeTax3;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Gross Pay: " + grossSalary);
                Console.WriteLine("Total Deductions: " + (sss + philHealth + pagIbig));
                Console.WriteLine("Income Tax: " + incomeTax3);
                Console.WriteLine("Net Salary: " + netSalary3);

            }
            else if (taxableIncome > 66667 && (taxableIncome <= 166667))
            {
                double incomeTax4 = ((taxableIncome - 20833) * 0.25);
                double netSalary4 = taxableIncome - incomeTax4;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Gross Pay: " + grossSalary);
                Console.WriteLine("Total Deductions: " + (sss + philHealth + pagIbig));
                Console.WriteLine("Income Tax: " + incomeTax4);
                Console.WriteLine("Net Salary: " + netSalary4);
            }
            else if (taxableIncome > 166667 && (taxableIncome <= 666667))
            {
                double incomeTax5 = ((taxableIncome - 20833) * 0.30);
                double netSalary5 = taxableIncome - incomeTax5;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Gross Pay: " + grossSalary);
                Console.WriteLine("Total Deductions: " + (sss + philHealth + pagIbig));
                Console.WriteLine("Income Tax: " + incomeTax5);
                Console.WriteLine("Net Salary: " + netSalary5);

            }
            else
            {
                //income tax > 666667
                double incomeTax6 = ((taxableIncome - 20833) * 0.35);
                double netSalary6 = taxableIncome  - incomeTax6;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Gross Pay: " + grossSalary);
                Console.WriteLine("Total Deductions: " + (sss + philHealth + pagIbig));
                Console.WriteLine("Income Tax: " + incomeTax6);
                Console.WriteLine("Net Salary: " + netSalary6);

            }

        }
    }
}
