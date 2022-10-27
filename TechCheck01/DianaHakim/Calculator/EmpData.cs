using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Diana Hakim W0420915


namespace Calculator
{
    public class EmpData
    {
        private static readonly double TAX_AMOUNT = 0.25;
        private static readonly double DEPENDENT_RATE = 0.05;

        public Dictionary<string, double> EmpAccount(double weeklysalary, int numdependents)
        {
            // calculate with rates 
            double taxamount = weeklysalary * TAX_AMOUNT; //.25
            double dependentdeduction = numdependents * (weeklysalary * DEPENDENT_RATE); //.05
            // net tax =  tax amount -  a per-dependent from the total tax withheld.                                                                                                                                                                       // net tax: tax amount -  a per-dependent deduction from the total tax withheld. 
            double nettax = taxamount - (dependentdeduction);
            double totaltakehome = weeklysalary - nettax;
            Dictionary<string, double> data = new Dictionary<string, double>();
            data.Add("Tax Amount", taxamount);
            data.Add("Dependent Deduction", dependentdeduction);
            data.Add("Net Tax Amount", nettax);
            data.Add("Total Take Home", totaltakehome);
            return data;
            //double[] EmpData = { taxamount, dependentdeduction, nettax, totaltakehome };
            //return EmpData;
        }
    }
}
