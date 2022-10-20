using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace SalaryCalculatorTestProject
{
    internal class TaxData
    {
        //ProvincialTaxWithheld: 60.0
        public double ProvincialTaxWithheld { get; internal set; }
        public double FederalTaxwithheld { get; internal set; }//FederalTaxWithheld: 250.0
        public double DependentDeduction { get; internal set; }//DependentDeduction: 40.0
        public double TotalWithheld { get; internal set; }//TotalWithheld: 270.0
        public double TakeHome { get; internal set; }//TotalTakeHome: 730.0

        internal void SetValues(double[] values)
        {
            ProvincialTaxWithheld = values[0];
            FederalTaxwithheld =    values[1];
            DependentDeduction =    values[2];
            TotalWithheld =         values[3];
            TakeHome =              values[4];
        }
    }
}