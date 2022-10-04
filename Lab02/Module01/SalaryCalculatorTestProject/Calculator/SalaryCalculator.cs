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
        //Provincial withholding tax is calculated at 6.0 %.
        private static readonly double PROVINCIAL_RATE = 0.06;
        private static readonly double FEDERAL_RATE = 0.25;
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

        public double[] TaxWitheld(double weeklySalary, int numDependents)
        {
            //Provincial withholding tax is calculated at 6.0 %.
            double ProvincialTaxWithheld = weeklySalary * PROVINCIAL_RATE;
            //Federal withholding tax is calculated at 25.0 %.
            double FederalTaxWithheld = weeklySalary * FEDERAL_RATE;
            //The tax deduction for dependents is calculated at 2.0 % of the employee’s salary per dependent.
            double DependentDeduction = 0;
            for (int i = 0; i < numDependents; i++)
            {
                DependentDeduction += weeklySalary * DEPENDENT_RATE;
            }
            double TotalWithheld = ProvincialTaxWithheld + FederalTaxWithheld + DependentDeduction;
            double TotalTakeHome = weeklySalary - TotalWithheld;
            double[] TaxData = {ProvincialTaxWithheld, FederalTaxWithheld, DependentDeduction, TotalTakeHome, TotalTakeHome};
            return TaxData;
        }



        //public void TaxWitheld(double weeklySalary, int numDependents)
        //{
        //    //Provincial withholding tax is calculated at 6.0 %.
        //    double ProvincialTaxWithheld = weeklySalary * PROVINCIAL_RATE;
        //    //Federal withholding tax is calculated at 25.0 %.
        //    double FederalTaxWithheld = weeklySalary * FEDERAL_RATE;
        //    //The tax deduction for dependents is calculated at 2.0 % of the employee’s salary per dependent.
        //    double DependentDeduction = 0;
        //    for (int i = 0; i < numDependents; i++)
        //    {
        //        DependentDeduction += (weeklySalary * DEPENDENT_RATE);
        //    }
        //    double TotalWithheld = ProvincialTaxWithheld + FederalTaxWithheld + DependentDeduction;
        //    double TotalTakeHome = weeklySalary - TotalWithheld;
        //    //[ProvincialTaxWithheld, FederalTaxWithheld, DependentDeduction, TotalTakeHome, TotalTakeHome]; 
        //    return;
        //}


    }
}
