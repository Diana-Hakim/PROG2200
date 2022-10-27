using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;


        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            if (hourlyWage <= 0)
            {
                Console.WriteLine(hourlyWage < 0);
                throw new InvalidOperationException("Hourly wage must greater then zero."); //"Hourly wage must greater then zero
            }
            return hourlyWage * HoursInYear;
        }

        public decimal GetHourlyWage(int annualSalary)
        {
            if (annualSalary <= 0)
            {
                throw new InvalidOperationException("Yearly wage must greater then zero.");
            }
            return annualSalary / HoursInYear;
        }
        //Add a function that calculates the total amount of tax withheld from an employee’s weekly salary.
        //The program will calculate and output the amount of
        //tax,
        //the dependent tax deduction,
        //net tax amount, and the
        //user’s final take-home amount.


    }
}
