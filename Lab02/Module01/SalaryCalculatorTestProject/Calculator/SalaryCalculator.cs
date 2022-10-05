using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculator
    {
        const int HoursInYear = 2080;
        //Provincial withholding tax is calculated at 6.0 %.
        private static readonly double PROVINCIAL_RATE = 0.06;
        //Federal withholding tax is calculated at 25.0 %.
        private static readonly double FEDERAL_RATE = 0.25;
        //The tax deduction for dependents is calculated at 2.0 % of the employee’s salary per dependent.
        private static readonly double DEPENDENT_RATE = 0.02;
        //public double[] TaxData; 

        public decimal GetAnnualSalary(decimal hourlyWage) 
        {
            if (hourlyWage <= 0) 
            {
                throw new InvalidOperationException("Hourly wage must greater then zero."); //"Hourly wage must greater then zero
            }
            return hourlyWage* HoursInYear; 
        }
        public decimal GetHourlyWage(int annualSalary) 
        {
            if (annualSalary <= 0)
            {
                throw new InvalidOperationException("Yearly wage must greater then zero."); //"Yearly wage must greater then zero
            }
            return annualSalary / HoursInYear; 
        }

        public global::SalaryCalculatorTestProject.TaxData TaxWitheld(double weeklysalary, int numdependents)
        {
            // calculate with rates 
            double provincialtaxwithheld = weeklysalary * PROVINCIAL_RATE;
            double federaltaxwithheld = weeklysalary * FEDERAL_RATE;
            double dependentdeduction = numdependents * (weeklysalary * DEPENDENT_RATE);
            // totals
            double totalwithheld = provincialtaxwithheld + federaltaxwithheld + dependentdeduction;
            Log(totalwithheld, "totalwithheld");
            double totaltakehome = weeklysalary - totalwithheld;
            Log(totaltakehome, "totaltakehome");
            // data
            return (provincialtaxwithheld, federaltaxwithheld, dependentdeduction, totalwithheld, totaltakehome);
        }

        public double[] Taxwtheld(double weeklysalary, int numdependents)
        {
            // calculate with rates 
            double provincialtaxwithheld = weeklysalary * PROVINCIAL_RATE;
            double federaltaxwithheld = weeklysalary * FEDERAL_RATE;
            Log(federaltaxwithheld, "federaltaxwithheld");
            double dependentdeduction = numdependents * (weeklysalary * DEPENDENT_RATE);
            // totals
            double totalwithheld = (provincialtaxwithheld + federaltaxwithheld) - dependentdeduction;
            Log(totalwithheld, "totalwithheld");
            double totaltakehome = weeklysalary - totalwithheld;
            Log(totaltakehome, "totaltakehome");
            // data
            double[] taxdata = { provincialtaxwithheld, federaltaxwithheld, dependentdeduction, totalwithheld, totaltakehome };
            return taxdata;
        }

        private void Log(double value, string print) 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(print+" Value: "+ value);
            Console.ForegroundColor = ConsoleColor.Black;

        }

    }
}
