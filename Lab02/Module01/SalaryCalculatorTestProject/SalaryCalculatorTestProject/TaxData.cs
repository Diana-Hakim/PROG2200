using System.Runtime.ConstrainedExecution;

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

    }
}